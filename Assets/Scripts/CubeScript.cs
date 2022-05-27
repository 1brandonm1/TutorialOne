using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Rigidbody rbCube;
    // Start is called before the first frame update
    void Start()
    {
        // Assigns Rigidbody to cube
        rbCube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Gives UpArrow "jumping" functionality for cube
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rbCube.AddForce(Vector3.up * 500);
        }
        // Gives cube velocity
        rbCube.velocity = Vector3.forward * 20f;
    }
}

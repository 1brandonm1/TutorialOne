using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject, 3f);
        // gameObject will be destroyed 3 secs after start
    }

    // Update is called once per frame
    void Update()
    {
        // Destroys gameObject when pressing spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
    // Function for destroying gameObject needed here instead of Start()
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

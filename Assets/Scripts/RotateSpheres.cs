using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//can find documentation w/ monobehavior
public class RotateSpheres : MonoBehaviour
{
    Vector3 movement;

    // "public" allows these vars to be seen/modified in Unity
    public int xi, yi, zi;

    // Start is called before the first frame update
    void Start()
    {
        movement = new Vector3(xi, yi, zi);
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime allows the movement to be smooth
        transform.Rotate(movement * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabbing : MonoBehaviour
{
    public float speed;
    public Vector3 Hand;
    public Transform phone;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Axis1D.PrimaryIndexTrigger"))
        {
            transform.position = phone.position + Hand;

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlVelocity : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rgbd2D;

    [SerializeField]
    Text mass, drag;

    void Update()
    {
        mass.text = rgbd2D.mass.ToString("0.00");
        drag.text = rgbd2D.drag.ToString("0.00");

        if (Input.GetKey(KeyCode.Z))
        {
            rgbd2D.mass += (.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.X))
        {
            rgbd2D.mass -= (.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.C))
        {
            rgbd2D.drag += (.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.V))
        {
            rgbd2D.drag -= (.1f * Time.deltaTime);
        }

    }
}

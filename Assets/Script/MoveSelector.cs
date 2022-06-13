using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelector : MonoBehaviour
{
    [SerializeField]
    ControllerMousePhysics mouse;

    [SerializeField]
    ControllerWASD WASD;

    public bool keyboard = false;

    [SerializeField]
    Rigidbody2D rgb2d;

    void Start()
    {
        mouse = this.GetComponent<ControllerMousePhysics>();
        WASD = this.GetComponent<ControllerWASD>();
    }

    void Update()
    {
        Cursor.visible = keyboard;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            keyboard = !keyboard;
        }

        if (keyboard)
        {
            mouse.enabled = false;
            rgb2d.velocity = new Vector2(0,0);

            WASD.enabled = true;
        }
        else
        {
            mouse.enabled = true;
            WASD.enabled = false;
        }
    }
}

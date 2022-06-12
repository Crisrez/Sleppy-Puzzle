using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMousePhysics : MonoBehaviour
{
    [SerializeField]
    Transform player, target;

    [SerializeField]
    SpriteRenderer fanta;

    [SerializeField]
    Rigidbody2D rgb2d;

    [SerializeField]
    Camera camera;

    [SerializeField]
    Vector3 mouse;

    void Update()
    {
        mouse = camera.ScreenToWorldPoint(Input.mousePosition);
        target.position = new Vector2(mouse.x, mouse.y);

        mouse = new Vector3(mouse.x, mouse.y, 0);

        if (player.position != mouse)
        {
            rgb2d.AddForce((mouse - player.position).normalized, ForceMode2D.Force);
        }

        if (rgb2d.velocity.magnitude > 0.3f)
        {
            if (mouse.x > player.position.x)
            {
                fanta.flipX = true;
            }
            else
            {
                fanta.flipX = false;
            }
        }
    }
}

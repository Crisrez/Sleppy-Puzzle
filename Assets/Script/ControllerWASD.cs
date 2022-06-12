using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWASD : MonoBehaviour
{
    [SerializeField]
    Transform player;
    
    [SerializeField]
    float wasdX, wasdY, velocity;

    [SerializeField]
    SpriteRenderer fanta;

    void FixedUpdate()
    {
        wasdX = Input.GetAxis("Horizontal");
        wasdY = Input.GetAxis("Vertical");
        
        player.position += new Vector3(wasdX, wasdY, 0) * velocity * Time.deltaTime;

        if (wasdX > 0)
        {
            fanta.flipX = true;
        }
        else if (wasdX < 0)
        {
            fanta.flipX = false;
        }
        else
        {
            fanta.flipX = fanta.flipX;
        }
    }
}

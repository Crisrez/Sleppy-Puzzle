using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerWASD : MonoBehaviour
{
    [SerializeField]
    Transform player;
    
    [SerializeField]
    float wasdX, wasdY, velocity;

    void FixedUpdate()
    {
        wasdX = Input.GetAxis("Horizontal");
        wasdY = Input.GetAxis("Vertical");
        
        player.position += new Vector3(wasdX, wasdY, 0) * velocity * Time.deltaTime;
    }
}

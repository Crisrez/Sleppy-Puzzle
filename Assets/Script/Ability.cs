using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rgbd2d;

    [SerializeField]
    float freno, distancia, velocidad;

    [SerializeField]
    Transform target;

    private void Start()
    {
        target = this.GetComponent<Transform>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Colisione");

            if ((target.position - collision.transform.position).magnitude < distancia)
            {
                if (rgbd2d.velocity.magnitude < velocidad)
                {
                    rgbd2d.velocity -= new Vector2(freno * Time.deltaTime, freno * Time.deltaTime);
                    /*if (rgbd2d.velocity.magnitude < velocidad / 5)
                    {
                        rgbd2d.velocity = new Vector2(0, 0);
                        collision.transform.position = target.position;
                    }*/
                }
            }
        }
    }

}

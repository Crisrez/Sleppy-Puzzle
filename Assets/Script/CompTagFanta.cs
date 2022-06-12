using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompTagFanta : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Maldecir>().fanta = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            this.GetComponent<Maldecir>().fanta = false;
        }
    }
}

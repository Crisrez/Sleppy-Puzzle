using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompTagTarget : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            this.GetComponent<Maldecir>().target = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Target")
        {
            this.GetComponent<Maldecir>().target = false;
        }
    }
}

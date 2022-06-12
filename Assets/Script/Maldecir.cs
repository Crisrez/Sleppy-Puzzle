using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maldecir : MonoBehaviour
{
    public bool fanta;
    public bool target;

    [SerializeField]
    Image minijuego;

    void Update()
    {
        if (fanta && target && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Estoy maldito");
            minijuego.enabled = true;
            Time.timeScale = 0;
        }
    }
}

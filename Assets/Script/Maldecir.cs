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

    void Start()
    {
        minijuego = GameObject.Find("Minijuego").GetComponent<Image>();    
    }

    void Update()
    {
        if (fanta && target && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("Maldiciendo");
            minijuego.enabled = true;
            Time.timeScale = 0;
        }
        if (fanta && target && Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Maldito");
            minijuego.enabled = false;
            Time.timeScale = 1;
        }
    }
}

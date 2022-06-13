using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maldecir : MonoBehaviour
{
    public bool fanta, target, can = true;

    [SerializeField]
    MoveSelector keyboard;

    [SerializeField]
    Image minijuego;

    void Start()
    {
        minijuego = GameObject.Find("Minijuego").GetComponent<Image>();
        keyboard = GameObject.Find("GameController").GetComponent<MoveSelector>();
    }

    void Update()
    {
        if (!keyboard.keyboard)
        {
            if (fanta && target && can && Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("Maldiciendo");
                minijuego.enabled = true;
                Time.timeScale = 0;
            }
            if (fanta && target && Input.GetKeyDown(KeyCode.N))
            {
                can = false;
                Debug.Log("Maldito");
                minijuego.enabled = false;
                Time.timeScale = 1;
            }
        }
        else
        {
            if (fanta && can && Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("Maldiciendo");
                minijuego.enabled = true;
                Time.timeScale = 0;
            }
            if (fanta && Input.GetKeyDown(KeyCode.N))
            {
                can = false;
                Debug.Log("Maldito");
                minijuego.enabled = false;
                Time.timeScale = 1;
            }
        }
        
    }
}

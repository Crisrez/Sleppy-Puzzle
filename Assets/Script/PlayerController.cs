using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject objetivo;
    
    public Camera camera;

    public GameObject red, blue, green;

    public float fuerza;

    public Vector3 position = new Vector3();

    public float mouseX, mouseY;
    public float sensitive = 15;
    public float wasdX, wasdY;

    public bool delay;
    public bool follow;
    public bool wasd;

    void Start()
    {
        if (camera != null)
        {
            camera = Camera.main;
        }
        Cursor.visible = false;

        delay = false;
        follow = true;
        wasd = false;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        position = (camera.ScreenToWorldPoint(Input.mousePosition));

        if (Input.GetKeyDown(KeyCode.Z))
        {
            delay = true;
            follow = false;
            wasd = false;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            delay = false;
            follow = true;
            wasd = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            delay = false;
            follow = false;
            wasd = true;
        }

        if (player.transform.position != position)
        {
            Debug.Log((objetivo.transform.position - player.transform.position).normalized);
            player.GetComponent<Rigidbody2D>().AddForce((objetivo.transform.position - player.transform.position).normalized);
            if (player.GetComponent<Rigidbody2D>().velocity >= fuerza)
            {

            }
        }


        if (follow)
        {
            red.SetActive(true);
            blue.SetActive(false);
            green.SetActive(false);

            objetivo.transform.position = new Vector3(position[0], position[1], 0);
        }
        /*else if (delay)
        {
            red.SetActive(false);
            blue.SetActive(true);
            green.SetActive(false);

            player.transform.position += new Vector3(mouseX, mouseY, 0) * sensitive * Time.deltaTime;
        }
        else if (wasd)
        {
            red.SetActive(false);
            blue.SetActive(false);
            green.SetActive(true);

            wasdX = Input.GetAxis("Horizontal");
            wasdY = Input.GetAxis("Vertical");

            player.transform.position += new Vector3(wasdX, wasdY, 0) * sensitive/2 * Time.deltaTime;
        }*/
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba1 : MonoBehaviour
{
    public Maldecir[] objetos;

    [SerializeField]
    bool[] cans;

    [SerializeField]
    int cooldown, malditos;

    [SerializeField]
    int[] ubicaciones;

    [SerializeField]
    bool existo;

    void Start()
    {
        objetos = FindObjectsOfType<Maldecir>();

        cans = new bool[objetos.Length];

        for (int i = 0; i < objetos.Length; i++)
        {
            cans[i] = objetos[i].can;
        }

        ubicaciones = new int[cooldown];
    }

    void Update()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            cans[i] = objetos[i].can;
        }

        for (int i = 0; i < cans.Length; i++)
        {
            if (!cans[i])
            {
                existo = false;
                foreach (var item in ubicaciones)
                {
                    if (item == i)
                    {
                        existo = true;
                    }
                }

                if (!existo)
                {
                    malditos++;

                    for (int l = 0; l < cooldown; l++)
                    {
                        if (malditos == l + 1)
                        {
                            ubicaciones[malditos - 1] = i;
                        }
                    }
                }


                if (malditos == cooldown)
                {
                    Debug.Log("hola");
                    malditos = 0;
                    objetos[ubicaciones[0]].can = true;
                }

            }
        }
    }
}

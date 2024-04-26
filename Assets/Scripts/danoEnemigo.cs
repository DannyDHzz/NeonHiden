using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danoEnemigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Debug.Log("Daño del enemigo");

        }

    }

}

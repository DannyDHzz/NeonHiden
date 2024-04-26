using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoUno : MonoBehaviour
{
    public float rangoAlerta;
    public LayerMask capaJugador;
    public Transform jugador;
    public float velocidad;

    bool estarAlerta;


    void Start()
    {
        
    }

    
    void Update()
    {
        //estarAlerta = Physics.CheckSphere(transform.position, rangoAlerta, capaJugador);

        //if(estarAlerta == true)
        //{
        //    Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
        //    transform.LookAt(posJugador);
        //    //transform.LookAt(new Vector3(jugador.position.x, transform.position.y, jugador.position.z));
        //    transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);


        //}

        RaycastHit hit;
        Vector3 direccionJugador = jugador.position - transform.position;
        if (Physics.Raycast(transform.position, direccionJugador, out hit, rangoAlerta, capaJugador))
        {
            // Si el Raycast golpea al jugador, establece estarAlerta como verdadero
            if (hit.collider.CompareTag("Player"))
            {
                estarAlerta = true;
            }
            else
            {
                estarAlerta = false;
            }
        }
        else
        {
            estarAlerta = false;
        }

        if (estarAlerta)
        {
            Vector3 posJugador = new Vector3(jugador.position.x, transform.position.y, jugador.position.z);
            transform.LookAt(posJugador);
            transform.position = Vector3.MoveTowards(transform.position, posJugador, velocidad * Time.deltaTime);
        }

    }

    //Collision
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Verifica si el objeto con el que colisionó es el jugador
        {
            // Aplica daño al jugador
            Debug.Log("Te han golpeado");
            //    //PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            //    //if (playerHealth != null)
            //    //{
            //    //    playerHealth.TakeDamage(damageAmount);
            //    //}
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoAlerta);
    }

}

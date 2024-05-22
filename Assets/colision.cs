using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
      
    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Finish"))
        {
            // Destruir ambos objetos
            Debug.Log("El objeto está colisionando");
            Destroy(other.gameObject); // Destruir el objeto con el tag "GameController"
            Destroy(gameObject); // Destruir el objeto que tiene este script adjunto
        }

        if (other.CompareTag("Finish"))
        { 
            Destroy(gameObject); 
        }
    }
}

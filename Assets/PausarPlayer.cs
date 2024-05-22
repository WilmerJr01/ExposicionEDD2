using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarPlayer : MonoBehaviour
{
    // Almacena la posición X del jugador cuando colisiona con la barrera
    private float posicionXOriginal;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto que colisionó con la barrera tiene el tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Obtener la posición X actual del jugador
            posicionXOriginal = collision.transform.position.x;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        // Verificar si el objeto que sigue colisionando con la barrera tiene el tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Mantener la posición X del jugador
            Vector3 posicionActual = collision.transform.position;
            posicionActual.x = posicionXOriginal;
            collision.transform.position = posicionActual;
        }
    }
}

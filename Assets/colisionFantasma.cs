using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionFantasma : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.5f; // Velocidad de movimiento hacia el jugador
    private Transform playerTransform;

    void Start()
    {
        // Encontrar al jugador por su tag "Player"
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogWarning("Player not found. Make sure your player has the tag 'Player'.");
        }
    }

    void Update()
    {
        // Moverse hacia el jugador
        if (playerTransform != null)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

}

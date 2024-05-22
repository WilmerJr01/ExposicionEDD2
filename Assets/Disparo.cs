using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectilPrefab; // El prefab del proyectil
    public Transform puntoDeDisparo; // El punto desde donde se disparará el proyectil
    public float velocidadProyectil = 10f; // La velocidad del proyectil

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        // Instanciar el proyectil en la posición y rotación del punto de disparo
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, puntoDeDisparo.rotation);
        
        // Obtener el componente Rigidbody2D del proyectil y darle velocidad
        Rigidbody2D rb = proyectil.GetComponent<Rigidbody2D>();
        rb.velocity = puntoDeDisparo.right * velocidadProyectil; // Cambia .right según la dirección de disparo
    }
}

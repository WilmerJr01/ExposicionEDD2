using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject proyectilPrefab; // El prefab del proyectil
    public Transform puntoDeDisparo; // El punto desde donde se disparará el proyectil
    public float velocidadProyectil = 10f; // La velocidad del proyectil
    public float velocidadMovimiento = 5f; // La velocidad de movimiento del jugador

    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator animator;
    private bool Tiro = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Movimiento
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        Vector2 movimiento = new Vector2(movimientoHorizontal, 0).normalized;
        rb.velocity = movimiento * velocidadMovimiento;

        // Cambiar la dirección del sprite
        if (movimientoHorizontal != 0)
        {
            sr.flipX = movimientoHorizontal > 0;
        }

        // Disparo
        if (Input.GetKeyDown(KeyCode.F) && !Tiro)
        {
            Tiro = true;
            Disparar(movimiento); // Normalizar el vector de movimiento para obtener la dirección
            animator.SetBool("disparo", Tiro);
            StartCoroutine(ResetTiro());
        }

        // Actualizar animaciones
        if (movimientoHorizontal != 0){
            animator.SetFloat("Horizontal", Mathf.Abs(movimientoHorizontal));
        } else {
            animator.SetFloat("Horizontal", 0);
        }
    }

    void Disparar(Vector2 direccionDisparo)
    {
        if (direccionDisparo == Vector2.zero)
        {
            direccionDisparo = Vector2.right * (sr.flipX ? 1 : -1); // Disparar en la dirección en que está mirando el sprite
        }
        // Instanciar el proyectil en la posición y rotación del punto de disparo
        GameObject proyectil = Instantiate(proyectilPrefab, puntoDeDisparo.position, Quaternion.identity);

        // Rotar el proyectil en la dirección del disparo
        float angle = Mathf.Atan2(direccionDisparo.y, direccionDisparo.x) * Mathf.Rad2Deg;
        SpriteRenderer proyectilSR = proyectil.GetComponent<SpriteRenderer>();
        PolygonCollider2D proyectilCollider = proyectil.GetComponent<PolygonCollider2D>();
        
        if (angle == 0f) { 
            proyectilSR.flipX = true;
        } 

        // Obtener el componente Rigidbody2D del proyectil y darle velocidad en la dirección del movimiento del jugador
        Rigidbody2D rbProyectil = proyectil.GetComponent<Rigidbody2D>();
        rbProyectil.velocity = direccionDisparo * velocidadProyectil;
    }

    IEnumerator ResetTiro()
    {
        yield return new WaitForSeconds(0.3f);
        Tiro = false;
        animator.SetBool("disparo", Tiro);
    }
}

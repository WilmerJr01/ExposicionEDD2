using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoPokemon : MonoBehaviour
{
    public GameObject fantasmaPoligonal;
    public GameObject fantasmaNormal;
    public GameObject fantasmaFondo;
    public GameObject picachuNormal;
    public GameObject picachuPoligonal;
    public GameObject picachuFondo;
    public GameObject tijeraNormal;
    public GameObject tijeraPoligonal;
    public GameObject tijeraFondo;

    public void PrenderModoNormal() { 
        if (!picachuNormal.activeSelf) { 
            picachuNormal.SetActive(true);
        }
        if (!picachuFondo.activeSelf) { 
            picachuFondo.SetActive(true);
        }
        fantasmaFondo.SetActive(false);
        fantasmaNormal.SetActive(false);
        fantasmaPoligonal.SetActive(false);
        picachuPoligonal.SetActive(false);
        tijeraFondo.SetActive(false);
        tijeraNormal.SetActive(false);
        tijeraPoligonal.SetActive(false);
    }

    public void PrenderModoPoligonal() { 
        if (!picachuPoligonal.activeSelf) { 
            picachuPoligonal.SetActive(true);
        }
        if (!picachuFondo.activeSelf) { 
            picachuFondo.SetActive(true);
        }
        fantasmaFondo.SetActive(false);
        fantasmaNormal.SetActive(false);
        fantasmaPoligonal.SetActive(false);
        picachuNormal.SetActive(false);
        tijeraFondo.SetActive(false);
        tijeraNormal.SetActive(false);
        tijeraPoligonal.SetActive(false);
    }
}

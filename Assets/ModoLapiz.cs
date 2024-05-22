using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoLapiz : MonoBehaviour
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
        if (!tijeraNormal.activeSelf) { 
            tijeraNormal.SetActive(true);
        }
        if (!tijeraFondo.activeSelf) { 
            tijeraFondo.SetActive(true);
        }
        picachuFondo.SetActive(false);
        picachuNormal.SetActive(false);
        fantasmaPoligonal.SetActive(false);
        picachuPoligonal.SetActive(false);
        fantasmaFondo.SetActive(false);
        fantasmaNormal.SetActive(false);
        tijeraPoligonal.SetActive(false);
    }

    public void PrenderModoPoligonal() { 
        if (!tijeraPoligonal.activeSelf) { 
            tijeraPoligonal.SetActive(true);
        }
        if (!tijeraFondo.activeSelf) { 
            tijeraFondo.SetActive(true);
        }
        picachuFondo.SetActive(false);
        picachuNormal.SetActive(false);
        fantasmaPoligonal.SetActive(false);
        picachuPoligonal.SetActive(false);
        fantasmaFondo.SetActive(false);
        fantasmaNormal.SetActive(false);
        tijeraNormal.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoFantasma : MonoBehaviour
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
        if (!fantasmaNormal.activeSelf) { 
            fantasmaNormal.SetActive(true);
        }
        if (!fantasmaFondo.activeSelf) { 
            fantasmaFondo.SetActive(true);
        }
        picachuFondo.SetActive(false);
        picachuNormal.SetActive(false);
        fantasmaPoligonal.SetActive(false);
        picachuPoligonal.SetActive(false);
        tijeraFondo.SetActive(false);
        tijeraNormal.SetActive(false);
        tijeraPoligonal.SetActive(false);
    }

    public void PrenderModoPoligonal() { 
        if (!fantasmaPoligonal.activeSelf) { 
            fantasmaPoligonal.SetActive(true);
        }
        if (!fantasmaFondo.activeSelf) { 
            fantasmaFondo.SetActive(true);
        }
        picachuFondo.SetActive(false);
        picachuNormal.SetActive(false);
        fantasmaNormal.SetActive(false);
        picachuPoligonal.SetActive(false);
        tijeraFondo.SetActive(false);
        tijeraNormal.SetActive(false);
        tijeraPoligonal.SetActive(false);
    }

    
}

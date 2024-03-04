using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlTiempo : MonoBehaviour
{
    float tiempoRestante;
    public TextMeshProUGUI texto;


    // Start is called before the first frame update
    void Start()
    {
        tiempoRestante = 5;
        StartCoroutine("CorrutinaContador");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CorrutinaContador()
    {
        while (tiempoRestante > -1)
        {

            texto.text = tiempoRestante.ToString();
            tiempoRestante -= 1;
            yield return new WaitForSeconds(1f);

        }

        ManagerUI manager = GameObject.Find("HandlerUI").GetComponent<ManagerUI>();
        manager.cambioescena(2);

    }
}

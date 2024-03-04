using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ScriptCorrutina : MonoBehaviour
{

    private TextMeshProUGUI texto;
    private float cont;

    // Start is called before the first frame update
    void Start()
    {
        texto = GameObject.Find("Contador").GetComponent<TextMeshProUGUI>();
        cont = 0;
        StopAllCoroutines();
        StartCoroutine("CorrutinaContador");
    }


    IEnumerator CorrutinaContador()
    {
        while (true)
        {
            
            texto.text = cont.ToString();
            cont += 1;
            yield return new WaitForSeconds(.25f);
        }

       
    }

    public void iniciarCorrutina()
    {
        StopAllCoroutines();
        StartCoroutine("CorrutinaContador");
    }

}

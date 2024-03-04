using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class p_trigger_detection_singleton : MonoBehaviour
{
    public TextMeshProUGUI score;

    float score_valor;

    private void Start()
    {
        score_valor = 0;
        score = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (SingletonDatosJuego.Instancia.isPlayerInEnemyArea)
        {
            score_valor++;
            score.text = score_valor.ToString();
            PlayerPrefs.SetFloat("score", score_valor);
        }
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SingletonDatosJuego.Instancia.isPlayerInEnemyArea = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SingletonDatosJuego.Instancia.isPlayerInEnemyArea = false;
        }
    }
}

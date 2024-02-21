using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class p_trigger_detection_singleton : MonoBehaviour
{
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

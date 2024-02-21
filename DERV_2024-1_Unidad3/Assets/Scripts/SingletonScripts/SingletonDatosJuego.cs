using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDatosJuego : MonoBehaviour
{
    public static SingletonDatosJuego Instancia { get; private set; }
    public bool isPlayerInEnemyArea;
    // Start is called before the first frame update
    //se checa si existe
    //si existe, checar que la que existe no sea la que se acaba de crear
    //


    ////////////////
    public float distance_enemy_to_player;


    ////////////////

    private void Awake()
    {
        if(Instancia != null)
        {
            if(Instancia != this)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            Instancia = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}

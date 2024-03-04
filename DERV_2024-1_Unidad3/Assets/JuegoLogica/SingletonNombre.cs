using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SingletonNombre : MonoBehaviour
{
    public static SingletonNombre Instancia { get; private set; }
    // Start is called before the first frame update
    //se checa si existe
    //si existe, checar que la que existe no sea la que se acaba de crear
    //



    ////////////////
    string nombre;
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

    public void setnombre(string nombre)
    {
        this.nombre= nombre;
    }

    public string getnombre()
    {
        return this.nombre;
    }


}

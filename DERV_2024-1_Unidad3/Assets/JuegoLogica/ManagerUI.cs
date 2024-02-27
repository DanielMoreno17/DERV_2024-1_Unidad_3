using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nombre_usuario;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene_temp = SceneManager.GetActiveScene();
        if (scene_temp.buildIndex == 2)
        {
            string nombre = PlayerPrefs.GetString("usuario", "");
            nombre_usuario.text = nombre;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioescena(int indexNuevoScena)
    {
        string nombre = nombre_usuario.text;
        PlayerPrefs.SetString("usuario", nombre);
        SceneManager.LoadScene(indexNuevoScena);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class ManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nombre_usuario;
    SingletonNombre nombresingleton;
    // Start is called before the first frame update
    void Start()
    {
        Scene scene_temp = SceneManager.GetActiveScene();
        if (scene_temp.buildIndex == 2)
        {
            string nombre = PlayerPrefs.GetString("usuario", "");
          
            float score = PlayerPrefs.GetFloat("score", 0);
            nombre_usuario.text = nombre + "score" + score.ToString();
            
            
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambioescena(int indexNuevoScena)
    {
        Scene temp = SceneManager.GetActiveScene();
        int indexScene = temp.buildIndex;
        if (indexScene == 0)
        {
            string nombre = nombre_usuario.text;
            PlayerPrefs.SetString("usuario", nombre);
        }

      
        SceneManager.LoadScene(indexNuevoScena);
    }
}

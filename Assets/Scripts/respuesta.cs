using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respuesta : MonoBehaviour
{
    public GameObject pregunta_bien; 
    public GameObject pregunta_mal;

    void Start()
    {
        
    }

    public void respuestas(bool respuesta)
    {
        if (respuesta)
        {
            pregunta_bien.SetActive(false);
            pregunta_bien.SetActive(true);
            int skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            pregunta_mal.SetActive(false);
            pregunta_mal.SetActive(true);
        }
        ///gameObject.SetActive(false);
        //transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);
        
    }
    
}

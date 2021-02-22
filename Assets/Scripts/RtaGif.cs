using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RtaGif : MonoBehaviour
{
    public GameObject pregunta_bien;
    public GameObject pregunta_mal;
    ///public GameObject pregunta_pensando;

    void Start()
    {

    }

    public void respuestas(bool respuesta)
    {
        if (respuesta)
        {
            pregunta_bien.SetActive(false);
            pregunta_bien.SetActive(true);
            ///pregunta_pensando.SetActive(false);
            int skor = PlayerPrefs.GetInt("skor") + 10;
            PlayerPrefs.SetInt("skor", skor);
        }
        else
        {
            pregunta_mal.SetActive(false);
            pregunta_mal.SetActive(true); 
          ///  pregunta_pensando.SetActive(false);
        }
        //gameObject.SetActive(false);
        //transform.parent.GetChild(gameObject.transform.GetSiblingIndex() + 1).gameObject.SetActive(true);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour
{
    public Text puntaje;
    public Text puntaje2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("skor", 0);
    }

    // Update is called once per frame
    void Update()
    {
        puntaje.text = PlayerPrefs.GetInt("skor").ToString();
        puntaje2.text = PlayerPrefs.GetInt("skor").ToString()+"/ 100";
    }
}
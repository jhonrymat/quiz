using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.Find("BackSonidoOn")==null){
            DontDestroyOnLoad(gameObject);
            GetComponent<AudioSource>().Play();
            gameObject.name = "BackSonidoOn"; 
            PlayerPrefs.SetFloat("volume",0.3f);      
            
               
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nombre : MonoBehaviour
{

    public InputField Nnombre;
    public InputField Ttiempo;
    public Text NnombreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Datos_()
    {

    NnombreText.text= Nnombre.text;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

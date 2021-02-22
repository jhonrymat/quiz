using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
///using UnityEngine.Time.deltaTime; 

public class Timers : MonoBehaviour
{
    Image timebar;
    public float maxTime = 5f;
    float timeLeft;
    public GameObject timeUpText;
    public GameObject textpuntuacion;
    public Text Gametime;
    public Text Gametime2;
    public InputField Ttiempo;
    bool TimerActive = true;
    public GameObject puntuacionFinal;
    public GameObject preguntas;

    // Start is called before the first frame update
    void Start()
    {
        timeUpText.SetActive(false);
        timebar = GetComponent<Image>();
        timeLeft = maxTime;
        //OBtenerTiempo();
        


    }
   /*public void OBtenerTiempo(){
        int n;
        n=int.Parse(Ttiempo.text);
        Debug.Log(n);
        maxTime=n;


    }*/
    

    // Update is called once per frame
    void Update()
    {
       
        
        if(TimerActive){
            if (timeLeft > 0)
            {
            timeLeft -= Time.deltaTime;
            timebar.fillAmount =timeLeft / maxTime;
            Gametime.text= timeLeft.ToString("F0") + " Seg";
            Gametime2.text= timeLeft.ToString("F0") + " Seconds";
            }else
            {
                puntuacionFinal.SetActive(true);
                timeUpText.SetActive(true);
                preguntas.SetActive(false);
                textpuntuacion.SetActive(false);
                Time.timeScale=0;
            }
        }
    }
    public void mostrarTiempo()
    {
        TimerActive=false;
        Debug.Log(Gametime);
    }
}

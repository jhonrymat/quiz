using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramdon : MonoBehaviour
{

    public Timers PausarTiempo;
    public GameObject final;
    public GameObject TPuntaje;
    public GameObject Tbarra;
    public GameObject TPuntos;
    public GameObject TtiempoP;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    int aqui = 0;

    public void random_objet()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
        int a = Random.Range(0, transform.childCount);

        if (transform.GetChild(a).name != "aqui") {
            aqui += 1;
            transform.GetChild(a).gameObject.SetActive(true);
            transform.GetChild(a).name = "aqui";
        }
        else
        {
            if (aqui < transform.childCount)
            {
                random_objet();
            }
            else
            {
                TPuntaje.SetActive(false);
                final.SetActive(true);
                Tbarra.SetActive(false);
                TPuntos.SetActive(false);
                TtiempoP.SetActive(false);
                PausarTiempo.mostrarTiempo();

                
                print("hecho");
                //Debug.Log(PausarTiempo);
            }
        }
        
    }

    public void random_tombol(){
        Vector3[] pos_tombol =new Vector3[transform.childCount];
        bool[]  terpasang =new bool [transform.childCount];

        for(int i = 0; i < pos_tombol.Length; i++)
        {
            pos_tombol[i] = transform.GetChild(i).transform.position;
            terpasang[i] = false;
        }

        for(int i =0 ; i<pos_tombol.Length; i++)
        {
            bool mengulang=true;
            while(mengulang)
            {
                int pos_random = Random.Range(0, transform.childCount);
                if(!terpasang[pos_random])
                {
                    transform.GetChild(i).transform.position=pos_tombol[pos_random];
                    terpasang[pos_random] = true;
                    mengulang = false;
                }
                else
                {
                    mengulang = true;
                }
            }
        }
    }

 

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

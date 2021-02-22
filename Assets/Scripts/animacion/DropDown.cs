using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    private Animator buttonAnim;
    private Boton boton;
    
    void Start()
    {
        buttonAnim = GetComponent<Animator>();
        boton = GameObject.Find("Code").GetComponent<Boton>();
    }
    void Update()
    {
        if (boton.showMenu)
            buttonAnim.SetBool("b_showMenu", true);
        if (!boton.showMenu)
            buttonAnim.SetBool("b_showMenu ", false);
    }
}

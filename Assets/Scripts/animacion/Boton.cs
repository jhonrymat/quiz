﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{
    public bool showMenu;

    public void ButtonShowMenu()
    {
        if (!showMenu)
            showMenu = true;
        else if (showMenu)
            showMenu = false;
    }
}

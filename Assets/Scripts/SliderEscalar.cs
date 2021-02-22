using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEscalar : MonoBehaviour
{
    public GameObject modelos3D;
    public Slider sliderEscalar;

    public void EscalarModelo()
    {
        modelos3D.transform.localScale = new Vector3(sliderEscalar.value, sliderEscalar.value, sliderEscalar.value);
    }
}

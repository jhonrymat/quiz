    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMenu : MonoBehaviour
{
   public void exit()
   {
       Application.Quit();
   }

   public void mailto(string mail)
   {
       Application.OpenURL("mailto:"+mail);
   }

   public void sound_volume(float volume)
   {
       PlayerPrefs.SetFloat("volume",volume);
   }
}

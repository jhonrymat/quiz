using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeScena : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneMonumento()
    {
        SceneManager.LoadScene("MonumentsAR");
    }
    public void SceneSelfie()
    {
        SceneManager.LoadScene("Selfie");
    }
    public void SceneVuforia()
    {
        SceneManager.LoadScene("ArFoundationScene");
    }

    public void SceneInicio()
    {
        SceneManager.LoadScene("inicio");
    }
}

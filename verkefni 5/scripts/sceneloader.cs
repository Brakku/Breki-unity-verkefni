using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using System.Security.Cryptography.X509Certificates;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene()
    {
        //script fyrir takkan til að byrja leikin
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        data.score =0;
        
    }
    public void exit()
    {
        //exit takki
        Application.Quit(); 
    }
}
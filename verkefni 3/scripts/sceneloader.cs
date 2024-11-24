using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    // til að loda scenes
    public Canvas thecanvas;
    public void LoadScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
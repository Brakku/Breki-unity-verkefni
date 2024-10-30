using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    public Canvas thecanvas;
    public void LoadScene()
    {
        // nær í fyrsta levelið fyrir menu scenið
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
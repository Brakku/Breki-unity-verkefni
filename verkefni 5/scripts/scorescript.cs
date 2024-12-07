using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scorescript : MonoBehaviour
{
    
    public TMP_Text scoretext;
    void Update()
    {
        // til að load script á UI
        scoretext.text = "Score: "+ data.score;
    }
}

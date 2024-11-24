using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Rendering.HighDefinition;

public class deathcheck : MonoBehaviour
{

    private GameObject statref;
    private int score;
    private int health;
    private Rigidbody rb;
    private  TextMeshProUGUI texti;
    private TextMeshProUGUI countText;
    

    void Start()
    {
        // Stats er external gameobject sem geimir líf og score
        statref = GameObject.Find("stats");
        score = statref.GetComponent<stats>().Score;
        health =statref.GetComponent<stats>().lif;

        texti= GameObject.Find("Text2").GetComponent<TextMeshProUGUI>();
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();

        rb = this.GetComponent<Rigidbody>();
        texti.text = "Líf " + health.ToString();
    }

    private void OnCollisionEnter(Collision other)
    {
        // ef það er snert vatn
        if (other.gameObject.CompareTag("death"))
        {
            SceneManager.LoadScene("losescrean", LoadSceneMode.Single);
            Debug.Log("deija");
        }


        if (other.gameObject.CompareTag("ovinur"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Leikmaður fær í sig óvin");
            
            TakeDamage(5);
            
        }

        // ef það er snert gull kubb
        if (other.gameObject.CompareTag("scoregive"))
        {
            other.gameObject.SetActive(false);
            score = statref.GetComponent<stats>().Score;
            score +=10;
            countText.text = "Stig: " + score.ToString();
            statref.GetComponent<stats>().Score= score;

            
        }


    }

    // frá innu en breitt aðeins
    public void TakeDamage(int damage)
    {
        
        health -= damage;
        damage=0;
        Debug.Log("health er núna" + health.ToString());
        
        texti.text = "Líf " + health.ToString();
        
        if (health <= 0)
        {
            health = 30;
            
            statref.GetComponent<stats>().lif = health;
            texti.text = "Líf " + health.ToString();
            SceneManager.LoadScene("losescrean", LoadSceneMode.Single);
            
        }
        statref.GetComponent<stats>().lif = health;
    }
}

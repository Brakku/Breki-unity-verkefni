using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovment : MonoBehaviour
{
    // tekið fyrst af innu en var breitt og bætt við
    public float speed = 0.2f;
    public float sideways = 0.2f;
    public float jump = 0.2f;
    //private Rigidbody leikmadur;

    private int score =0;
    public int lives =5;

    // geimir hversu margar coins voru í birjun
    private int maxscore;

    // ui stuff
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI liveText;
    public TextMeshProUGUI wintext;

    void Start()
    {
        Debug.Log("byrja");

        // telur coins
        maxscore = GameObject.FindGameObjectsWithTag("coin").Length;


        SetCountText();
        Setscoretext();

    }

    private void OnCollisionEnter(Collision other)
    {
        // ef snertir coin: hækka score og deactivate coin
        if (other.gameObject.CompareTag("coin"))
        {
            score++;
            other.gameObject.SetActive(false);
            Setscoretext();

        }
        // ef snertir obstikle: minka líf og deactivate obsticle
        if (other.gameObject.CompareTag("obsticle"))
        {
            lives--;
            other.gameObject.SetActive(false);
            SetCountText();

        }

    }


    // ui stuff
    void Setscoretext()
    {
        scoreText.text = "score: " + score.ToString() + "/"+ maxscore.ToString();

    }
    void SetCountText()
    {
        liveText.text = "lives: " + lives.ToString();

    }

    
    void FixedUpdate()
    {

        // lodar scenes ef stöðurnar eru réttar
        if (lives <= 0)
        {
            SceneManager.LoadScene("losescrean", LoadSceneMode.Single);
        }
        if (score >= maxscore)
        {
            if (SceneManager.GetActiveScene().name == "level2"){
                SceneManager.LoadScene("winscean", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("level2", LoadSceneMode.Single);
            }

        }

        // player hreifingar
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += -transform.forward * speed;

        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * jump;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * jump;
        }

        //sný player
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))//snúa leikmanni
        {
            transform.Rotate(new Vector3(0, -5, 0));
        }

    }
}

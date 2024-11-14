using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{
 
    public int count;
    public GameObject sprenging;
    private TextMeshProUGUI countText;
    void Start()
    {
        
        countText = GameObject.Find("Text").GetComponent<TextMeshProUGUI>();

        // Stats er external gameobject sem geimir líf og score
        count = GameObject.Find("stats").GetComponent<stats>().Score;
        
        

    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        // tekið af innu en er breitt
        if (collision.collider.tag == "kula")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("varð fyrir kúlu");

            count = GameObject.Find("stats").GetComponent<stats>().Score;
            count += 1;
            countText.text = "Stig: " + count.ToString();
            GameObject.Find("stats").GetComponent<stats>().Score = count;

            Sprengin();
        }
    }

    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;

    private int count;

    //hreiving
    private float movementX;
    private float movementY;

    public float speed = 0;

    //ui stuff
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    void Start()
    {
        // Initialize stuff
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }

    // þegar leikurin fær input
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // betra en að vera kallað hverja frame
    private void FixedUpdate()
    {
        //hreiving
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }


    void OnTriggerEnter(Collider other)
    {
        // ef colectable er snert
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCountText();
        }
    }

    // update á talinu
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        // ef þú vinnur
        if (count >= 11)
        {
            winTextObject.SetActive(true);

            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ef þú tafap
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

            winTextObject.gameObject.SetActive(true);
            winTextObject.GetComponent<TextMeshProUGUI>().text = "You Lose!";

        }

    }


}
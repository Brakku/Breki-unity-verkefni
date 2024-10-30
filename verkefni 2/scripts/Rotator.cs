using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //snír krónuni
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
    }
}

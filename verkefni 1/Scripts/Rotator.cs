using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //sn�r kubbinum
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        // sta�setningin sem mindav�lin � a� vera
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // passa a� �a� er � r�tta sta�
        transform.position = player.transform.position + offset;
    }
}
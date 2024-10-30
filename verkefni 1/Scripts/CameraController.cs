using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        // staðsetningin sem mindavélin á að vera
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // passa að það er á rétta stað
        transform.position = player.transform.position + offset;
    }
}
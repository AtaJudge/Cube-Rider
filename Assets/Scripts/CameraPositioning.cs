using System;
using UnityEngine;

public class CameraPositioning : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        transform.position = player.position + offset;
    }
}

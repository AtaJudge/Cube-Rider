using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            _playerMovement.enable = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

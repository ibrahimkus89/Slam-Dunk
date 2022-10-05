using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private GameManager _GameManager;
    [SerializeField] private AudioSource BallSound;
    private void OnTriggerEnter(Collider other)
    {
        BallSound.Play();
        if (other.CompareTag("Basket"))
        {
            _GameManager.Basket(transform.position);
        }
        else if (other.CompareTag("GameOver"))
        {
            _GameManager.Lost();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        BallSound.Play();

    }
}

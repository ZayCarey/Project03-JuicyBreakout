using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlaySoundOnHit : MonoBehaviour
{
    public AudioSource hitSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("block"))
        {
            hitSound.Play();  
        }
    }
}
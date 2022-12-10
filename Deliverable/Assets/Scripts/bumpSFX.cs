using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumpSFX : MonoBehaviour
{
    public AudioSource bumpSound;

    void OnCollisionEnter2D(Collision2D collision)
    {
        bumpSound.Play();
    }
}
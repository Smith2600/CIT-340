using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    void Start()
    {
        this.tag = "Enemy";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coconut")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coconut : MonoBehaviour
{
    public Rigidbody2D coconutRigidbody;

    private void Start()
    {
        coconutRigidbody.AddForce(Vector3.right * 0.25f, ForceMode2D.Impulse);
        this.tag = "Coconut";
    }
}
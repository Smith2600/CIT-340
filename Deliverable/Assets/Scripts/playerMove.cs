using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public GameObject coconutPrefab;
    public Rigidbody2D RB2D;
    public Animator animator;
    public AudioSource throwSound;

    private Vector3 offset = new Vector3(1f, 0, 0);
    private float moveHorizontal;
    private float moveVertical;
    private float moveSpeed;
    
    bool facingRight = true;

    void Start()
    {
        RB2D = GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject coconut = Instantiate(coconutPrefab, transform.position + offset, transform.rotation) as GameObject;
            throwSound.Play();
            Destroy(coconut, 1f);
        }
    }

    void FixedUpdate()
    {
        if (moveHorizontal != 0)
        {
            RB2D.AddForce(new Vector3(moveHorizontal * moveSpeed, 0), ForceMode2D.Impulse);
        }

        if (moveVertical > 0)
        {
            RB2D.AddForce(new Vector3(0, moveVertical * moveSpeed), ForceMode2D.Impulse);
        }

        if (moveHorizontal > 0 && !facingRight)
        {
            Flip();
        }

        if (moveHorizontal < 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        facingRight = !facingRight;
    }
}
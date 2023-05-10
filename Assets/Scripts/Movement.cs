using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    private Rigidbody2D rb;
    public float speed = 10;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private bool fasingRight = true;

    public GameObject buttomE;



    // Start is called before the first frame update
    void Start()
    {
        buttomE.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if (!fasingRight && moveInput.x > 0)
        {
            Flip();
        }
        else if (fasingRight && moveInput.x < 0)
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Flip()
    {
        fasingRight = !fasingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Object"))
        {
            buttomE.SetActive(true);
        }


    }
    private void OnTriggerExit2D(Collider2D other)
    {
        {

            {
                buttomE.SetActive(false);
            }

        }

    }
}

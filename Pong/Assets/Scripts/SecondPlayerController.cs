using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{


    public GameObject ball;
    public float moveSpeed = 20.0f;
    public float lerpSpeed = 1f;
    private Rigidbody2D myRB;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            if(myRB.velocity.y < 0)
            {
                myRB.velocity = Vector2.zero;
                myRB.velocity = Vector2.Lerp(myRB.velocity, Vector2.up * moveSpeed, lerpSpeed * Time.deltaTime);
            }
            else if (ball.transform.position.y < transform.position.y)
            {
                if (myRB.velocity.y > 0)
                {
                    myRB.velocity = Vector2.zero;
                    myRB.velocity = Vector2.Lerp(myRB.velocity, Vector2.down * moveSpeed, lerpSpeed * Time.deltaTime);
                }
            }
            else
            {
                myRB.velocity = Vector2.Lerp(myRB.velocity, Vector2.zero * moveSpeed, lerpSpeed * Time.deltaTime);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{

    float vertical;
    float horizontal;
    public GameObject ball;
    public float moveSpeed = 20.0f;
    public float lerpSpeed = 1f;
    public bool ifEnlargened = false;
    public bool ifShrunk = false;
    private Rigidbody2D myRB;
    private Vector2 zero;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        zero = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = myRB.velocity;
        myRB.velocity = velocity;
        var pos = transform.position;


        pos.x = Mathf.Clamp(pos.x + horizontal, 3, 7);
        pos.y = Mathf.Clamp(pos.y + vertical, -7, 7);
        transform.position = pos;

        if (ball.transform.position.y > transform.position.y)
        {
            if (ball.GetComponent<Rigidbody2D>().velocity.y < 0)
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

        if (ifEnlargened == true)
        {
            ItemLarge();
            ifShrunk = false;

        }

        if (ifShrunk == true)
        {
            ItemSmall();
            ifEnlargened = false;
        }

    }


    public void ItemLarge()
    {
        Vector2 scale = new Vector2(1, 5);
        transform.localScale = scale;
    }

    public void ItemSmall()
    {
        Vector2 scale = new Vector2(1, 1);
        transform.localScale = scale;
    }
}

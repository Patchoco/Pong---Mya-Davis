using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    Rigidbody2D myRB;

    float vertical;
    float horizontal;
    public bool ifEnlargened = false;
    public bool ifShrunk = false;


    private Vector2 zero;
    public float slideSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        zero = new Vector2(0, 0);
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = myRB.velocity;
        myRB.velocity = velocity;

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * slideSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * slideSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * slideSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * slideSpeed * Time.deltaTime);
        }


        var pos = transform.position;

        pos.x = Mathf.Clamp(pos.x + horizontal, -7, -3);
        pos.y = Mathf.Clamp(pos.y + vertical, -7, 7);
        transform.position = pos;




        if (ifEnlargened == true)
        {
            ifShrunk = false;
            ItemLarge();


        }

        if (ifShrunk == true)
        {
            ifEnlargened = false;
            ItemSmall();

        }

    }


    public void ItemLarge()
    {
        Vector2 scale = new Vector2(1, 5);
        transform.localScale = scale;
        StartCoroutine(waiter());
        ifEnlargened = false;
    }

    public void ItemSmall()
    {
        Vector2 scale = new Vector2(1, 1);
        transform.localScale = scale;
        StartCoroutine(waiter());
        ifShrunk = false;
    }

}

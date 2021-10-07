using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    Rigidbody2D myRB;

    float vertical;
    float horizontal;
    float originalWidth = 0.5f;
    float originalHeight = 2f;
    public AudioClip hit;
    public AudioClip item;
    private AudioSource speaker;

    public bool ifEnlargened = false;
    public bool ifShrunk = false;


    private Vector2 zero;
    public float slideSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        zero = new Vector2(0, 0);
        speaker = GetComponent<AudioSource>();
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
            StartCoroutine("waiter", true);
        }

        if (ifShrunk == true)
        {
            ItemSmall();
            ifEnlargened = false;
            StartCoroutine("waiter", true);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "ball")
        {
            speaker.clip = hit;
            speaker.Play();
        }
    }

    IEnumerator waiter(bool Waiting)
    {
        yield return new WaitForSeconds(3);
        if (Waiting)
        {
            ifEnlargened = false;
            ifShrunk = false;
            Vector2 scale = new Vector2(originalWidth, originalHeight);
            transform.localScale = scale;
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

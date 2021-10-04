﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysic : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject p1;
    public GameObject p2;
    public GameObject InstantiateP1Here;
    public GameObject InstantiateP2Here;
    private GameObject playernewInstance;

    public float thrust = 600.0f;
    public int fragility1 = 0;
    public int fragility2 = 0;
    public int breaking = 5;
    public bool ifFragile = false;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * -thrust);

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D contact = collision.GetContact(0);

        Vector2 velocity = collision.rigidbody.velocity;

        if (contact.point.x > transform.position.x)
        {
            Vector2 direction = new Vector2(0, 0);
            collision.rigidbody.AddForce(direction * thrust, ForceMode2D.Force);
            //            collision.rigidbody.AddForce(velocity / 10, ForceMode2D.velocity);
        }

        else if (contact.point.x < transform.position.x)
        {
            Vector2 direction = new Vector2(0, 0);
            collision.rigidbody.AddForce(direction * thrust, ForceMode2D.Force);
            //            collision.rigidbody.AddForce(velocity / 10, ForceMode2D.VelocityChange);
        }

        if (ifFragile == true && collision.gameObject.tag == "player1")
        {
            fragility1++;
            if (fragility1 > breaking)
            {
                Destroy(collision.gameObject);
                StartCoroutine(waiter());
                CreateP1Prefab();
            }
        }

        if (ifFragile == true && collision.gameObject.tag == "player2")
        {
            fragility2++;
            if (fragility2 > breaking)
            {
                Destroy(collision.gameObject);
                StartCoroutine(waiter());
                CreateP2Prefab();
            }
        }


    }

    public void CreateP1Prefab()
    {
        float instX = InstantiateP1Here.transform.position.x;
        float instY = InstantiateP1Here.transform.position.y;
        playernewInstance = Instantiate(p1, new Vector2(instX, instY), Quaternion.identity);
    }


    public void CreateP2Prefab()
    {
        float instX = InstantiateP2Here.transform.position.x;
        float instY = InstantiateP2Here.transform.position.y;
        playernewInstance = Instantiate(p2, new Vector2(instX, instY), Quaternion.identity);
    }
}
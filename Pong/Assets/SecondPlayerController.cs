﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayerController : MonoBehaviour
{


    public GameObject ball;
    public float moveSpeed = 20.0f;
    bool isMoving = false;
    float timeMoving = 0f;
    Vector2 direction = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enabled)
        {
            float distance = Mathf.Abs(ball.transform.position.x - transform.position.x);

            if (timeMoving > 0.1f)
            {
                isMoving = false;
                timeMoving = 0;
            }

            if (isMoving)
            {
                transform.Translate(direction * Time.deltaTime);
                timeMoving += Time.deltaTime;
            }

            else
            {
                if (distance <= 15)
                {
                    if (ball.transform.position.z > transform.position.z + 2)
                    {
                        transform.Translate(new Vector2(0, 0) * -moveSpeed * Time.deltaTime);
                        isMoving = true;
                        direction = new Vector2(0, 0) * -moveSpeed;
                    }

                    if (ball.transform.position.z < transform.position.z - 2)
                    {
                        transform.Translate(new Vector3(0, 0) * moveSpeed * Time.deltaTime);
                        isMoving = true;
                        direction = new Vector2(0, 0) * moveSpeed;
                    }
                }

                else
                {
                    float value = Random.Range(0f, 1f);
                    
                    if (value < 0.1)
                    {
                        transform.Translate(new Vector2(0, 0) * -moveSpeed * Time.deltaTime);
                        isMoving = true;
                        direction = new Vector2(0, 0) * -moveSpeed;
                    }

                    if (value < 0.2)
                    {
                        transform.Translate(new Vector3(0, 0) * moveSpeed * Time.deltaTime);
                        isMoving = true;
                        direction = new Vector2(0, 0) * moveSpeed;
                    }
                }
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    Rigidbody2D myRB;

    float vertical;
    float horizontal;

    private Vector2 zero;
    public float slideSpeed = 5.0f;

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
        velocity.x = Input.GetAxisRaw("Horizontal") * slideSpeed;
        velocity.y = Input.GetAxisRaw("Vertical") * slideSpeed;
        myRB.velocity = velocity;
    }
    
}

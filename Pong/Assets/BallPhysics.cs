using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour
{
    // Start is called before the first frame update

    public float thrust = 600.0f;

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * -thrust);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if(collision.gameObject.tag == "out_of_bounds")
        {
            Destroy(this.gameObject);
        }
    }
}

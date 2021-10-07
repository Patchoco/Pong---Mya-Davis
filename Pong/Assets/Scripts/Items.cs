using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject ShrinkItem;
    public GameObject GrowItem;
    public GameObject FragileItem;
    public BallPhysic bP;
    public PlayerController pC;
    public P2Controller sPC;
    public ItemSpawn iS;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player1")
        {

            if (gameObject.tag == "grow_item")
            {
                pC.ifEnlargened = true;
                Destroy(this.gameObject);
            }

            if (gameObject.tag == "shrink_item")
            {
                sPC.ifShrunk = true;
                Destroy(this.gameObject);
            }

            if (gameObject.tag == "fragile_item")
            {
                bP.ifFragile = true;
                Destroy(this.gameObject);
            }
        }

        if(collision.tag == "player2")
        {

            if (gameObject.tag == "grow_item")
            {
                sPC.ifEnlargened = true;
                Destroy(this.gameObject);
            }

            if (gameObject.tag == "shrink_item")
            {
                pC.ifShrunk = true;
                Destroy(this.gameObject);
            }

            if (gameObject.tag == "fragile_item")
            {
                bP.ifFragile = true;
                Destroy(this.gameObject);
            }
        }
    }
}

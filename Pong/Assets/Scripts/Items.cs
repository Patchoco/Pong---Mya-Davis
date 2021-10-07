using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public GameObject ShrinkItem;
    public GameObject GrowItem;
    public GameObject FragileItem;
    public BallPhysic bP;
    public GameObject InstantiateItemHere;
    public GameObject InstantiateSmallHere;
    private GameObject newInstance;
    public PlayerController pC;
    public P2Controller sPC;
    public ItemSpawn iS;
    public AudioSource speaker;
    public AudioClip itemget;


    // Start is called before the first frame update
    void Start()
    {
        speaker.GetComponent<AudioSource>();
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
                speaker.clip = itemget;
                speaker.Play();
                pC.ifEnlargened = true;
                Destroy(this.gameObject);
     //           StartCoroutine("waiter", true);
            }

            if (gameObject.tag == "shrink_item")
            {
                speaker.clip = itemget;
                speaker.Play();
                sPC.ifShrunk = true;
                Destroy(this.gameObject);
      //          StartCoroutine("waiter", false);
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
                speaker.clip = itemget;
                speaker.Play();
                sPC.ifEnlargened = true;
                Destroy(this.gameObject);
    //            StartCoroutine("waiter", true);

            }

            if (gameObject.tag == "shrink_item")
            {
                speaker.clip = itemget;
                speaker.Play();
                pC.ifShrunk = true;
                Destroy(this.gameObject);
     //           StartCoroutine("waiter", false);
            }

            if (gameObject.tag == "fragile_item")
            {
                bP.ifFragile = true;
                Destroy(this.gameObject);
            }
        }
    }
}

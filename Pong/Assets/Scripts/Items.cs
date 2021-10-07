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


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter(bool taken)
    {
        yield return new WaitForSeconds(2);
        if(taken)
        {
            float instX = InstantiateItemHere.transform.position.x;
            float instY = InstantiateItemHere.transform.position.y;
            newInstance = Instantiate(GrowItem, new Vector2(instX, instY), Quaternion.identity);
        }
        if(!taken)
        {
            float instX = InstantiateSmallHere.transform.position.x;
            float instY = InstantiateSmallHere.transform.position.y;
            newInstance = Instantiate(ShrinkItem, new Vector2(instX, instY), Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player1")
        {

            if (gameObject.tag == "grow_item")
            {
                pC.ifEnlargened = true;
                Destroy(this.gameObject);
                StartCoroutine("waiter", true);
            }

            if (gameObject.tag == "shrink_item")
            {
                sPC.ifShrunk = true;
                Destroy(this.gameObject);
                StartCoroutine("waiter", false);
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
                StartCoroutine("waiter", true);

            }

            if (gameObject.tag == "shrink_item")
            {
                pC.ifShrunk = true;
                Destroy(this.gameObject);
                StartCoroutine("waiter", false);
            }

            if (gameObject.tag == "fragile_item")
            {
                bP.ifFragile = true;
                Destroy(this.gameObject);
            }
        }
    }
}

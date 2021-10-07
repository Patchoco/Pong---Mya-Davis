using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public GameObject p1holder;
    public GameObject p2holder;
    public GameObject p1;
    public GameObject p2;
    public BallPhysic ballscript;

    // Start is called before the first frame update
    void Start()
    {
        ballscript.GetComponent<BallPhysic>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator waiter(bool playerSpawn)
    {
        yield return new WaitForSeconds(2);

        if (playerSpawn)
            p1holder = Instantiate(p1, new Vector2(-5, 0), Quaternion.identity);

        if (!playerSpawn)
            p2holder = Instantiate(p2, new Vector2(5, 0), Quaternion.identity);
    }

    public void Revive()
    {
        StartCoroutine("waiter", true);
    }

    public void RevivePlayer()
    {
        StartCoroutine("waiter", false);
    }
}

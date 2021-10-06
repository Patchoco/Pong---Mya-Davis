using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject ball;
    public SpriteChanger Rouge;
    public SpriteChanger Saxon;
    public GameObject InstantiateObjectHere;
    private GameObject newInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter(bool Goal)
    {
        yield return new WaitForSeconds(5);

        if(Goal)
        {
            CreatePrefab();
            Rouge.GetComponent<SpriteChanger>().NeutralFace();
            Saxon.GetComponent<SpriteChanger>().NeutralFace();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        StartCoroutine("waiter", true);
    }

    public void CreatePrefab()
    {
        float instX = InstantiateObjectHere.transform.position.x;
        float instY = InstantiateObjectHere.transform.position.y;
        newInstance = Instantiate(ball, new Vector2(instX, instY), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public GameObject ball;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        CreatePrefab();
    }

    public void CreatePrefab()
    {
        float instX = InstantiateObjectHere.transform.position.x;
        float instY = InstantiateObjectHere.transform.position.y;
        newInstance = Instantiate(ball, new Vector2(instX, instY), Quaternion.identity);
    }
}

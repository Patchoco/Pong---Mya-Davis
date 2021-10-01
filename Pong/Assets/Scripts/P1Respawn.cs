using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Respawn : MonoBehaviour
{
    public GameObject p1;
    public GameObject InstantiateObjectHere;
    private GameObject newInstance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject == Destroy)
        CreatePrefab();
    }


    public void CreatePrefab()
    {
        float instX = InstantiateObjectHere.transform.position.x;
        float instY = InstantiateObjectHere.transform.position.y;
        newInstance = Instantiate(p1, new Vector2(instX, instY), Quaternion.identity);
    }
}

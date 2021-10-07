using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{

    public GameObject Shrink;
    public GameObject Grow;
    private GameObject newShrinkInstance;
    private GameObject newGrowthInstance;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CreateGrowPrefab();
        CreateShrinkPrefab();
    }

    
    public void CreateShrinkPrefab()
    {
        newShrinkInstance = Instantiate(Shrink, new Vector2(2,2), Quaternion.identity);
    }

    public void CreateGrowPrefab()
    {
        newGrowthInstance = Instantiate(Grow, new Vector2(2,4), Quaternion.identity);
    }

 //   public void CreateFragilePrefab()
   // {
     //   float instX = ItemHolder.transform.position.x;
       // float instY = ItemHolder.transform.position.y;
        //newFragileInstance = Instantiate(Fragile, new Vector2(instX, instY), Quaternion.identity);

    //}
}

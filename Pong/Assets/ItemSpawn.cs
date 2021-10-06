﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawn : MonoBehaviour
{

    public GameObject ItemHolder;
    public GameObject Shrink;
    public GameObject Grow;
    public GameObject Fragile;
    private GameObject newShrinkInstance;
    private GameObject newGrowthInstance;
    private GameObject newFragileInstance;
    public bool item_present = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter(bool item_usage)
    {
        yield return new WaitForSeconds(5);

        if(item_usage, true && item_present, false)
        {
            CreateShrinkPrefab();
        }
    }
    
    public void CreateItem ()
    {
        CreateShrinkPrefab();
        
    }
    public void CreateShrinkPrefab()
    {
        item_present = true;
        float instX = ItemHolder.transform.position.x;
        float instY = ItemHolder.transform.position.y;
        newShrinkInstance = Instantiate(Shrink, new Vector2(instX, instY), Quaternion.identity);
    }

    public void CreateGrowPrefab()
    {
        float instX = ItemHolder.transform.position.x;
        float instY = ItemHolder.transform.position.y;
        newGrowthInstance = Instantiate(Grow, new Vector2(instX, instY), Quaternion.identity);
    }

    public void CreateFragilePrefab()
    {
        float instX = ItemHolder.transform.position.x;
        float instY = ItemHolder.transform.position.y;
        newFragileInstance = Instantiate(Fragile, new Vector2(instX, instY), Quaternion.identity);

    }
}

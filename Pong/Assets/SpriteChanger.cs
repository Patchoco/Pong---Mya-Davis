using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    //make this one into the list?
    public Sprite Confident;
    public Sprite Sad;
    public Sprite Neutral;


    // Start is called before the first frame update
    void Start()
    {
        NeutralFace();
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void ConfidentFace()
    {
        spriteRenderer.sprite = Confident;

//        NeutralFace();
    }

    public void SadFace()
    {
        spriteRenderer.sprite = Sad;
 //       NeutralFace();
    }

    public void NeutralFace()
    {
        spriteRenderer.sprite = Neutral;
    }
}

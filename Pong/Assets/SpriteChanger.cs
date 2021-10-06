using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite Confident;
    public Sprite Sad;
    public Sprite Neutral;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = Neutral;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void ConfidentFace()
    {
        spriteRenderer.sprite = Confident;

        NeutralFace();
    }

    void SadFace()
    {
        spriteRenderer.sprite = Sad;
        NeutralFace();
    }

    void NeutralFace()
    {
        spriteRenderer.sprite = Neutral;
    }
}

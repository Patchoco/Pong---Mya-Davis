using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class P1ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ball;
    public SpriteChanger RougeFaceTrigger;
    public SpriteChanger SaxonFaceTrigger;
    public Text ScoreText;
    public int Player1_Score = 0;

    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player1_Score++;
        SaxonFaceTrigger.GetComponent<SpriteChanger>().SadFace();
        RougeFaceTrigger.GetComponent<SpriteChanger>().ConfidentFace();
        ScoreText.text = Player1_Score.ToString();
        if (Player1_Score == 7)
        {
            p1gameover();
        }
    }



    public void p1gameover()
    {
        Debug.Log("Player 1 wins!");
        SceneManager.LoadScene("Player1Victory");
    }
}

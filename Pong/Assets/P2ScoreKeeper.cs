using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P2ScoreKeeper : MonoBehaviour
{
    public GameObject ball;

    public int Player2_Score = 0;

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
        Player2_Score++;
        if(Player2_Score == 7)
        {
            p2gameover();
        }
    }

    public void p2gameover()
    {
        Debug.Log("Player 2 wins!");
        SceneManager.LoadScene("Player2Victory");
    }
}

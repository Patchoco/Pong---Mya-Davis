using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ball;

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

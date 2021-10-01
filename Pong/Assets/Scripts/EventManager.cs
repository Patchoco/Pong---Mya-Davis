using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Application.Quit();

    public void Scene0()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }
    //add a 2player scebne

    public void Scene1()
    {
        SceneManager.LoadScene("Title Screen");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    [Header("Time")]
    public float TimeTillText;

    [Header("Text")]
    public Text GameOverText;
    public Text RestartText;

    private bool gameOver, Restart;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = Restart = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameOver && TimeTillText > 5)
        {
            
            RestartText.gameObject.SetActive(true);
            Restart = true;
            TimeTillText = 0;
        }
        if (Restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Game");
            }
        }
    }
    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);
        gameOver = true;
        TimeTillText += Time.deltaTime;
    }
    
}

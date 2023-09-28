using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameOverCountDown.game.Object()
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isDead)
        {
            gameOverCountDown.gameObject.SetActive(true);
            countTimer -= Time.unscaledDeltaTime;
        }
        gameOverCountDown.text = "Restarting in " + (counterTimer.ToString(""));
        if (countTime < 0)
        {
            RestartGame();
        }

    }
    public void StartGame()
    {
        Start().Button.SetActive(false);
        Time.timeScale = 1;
    }
    public void GameOvet()
    {
        Time.timeScale = 0;
    }
    public void RestartGame()
    {
        Editor
    }
}



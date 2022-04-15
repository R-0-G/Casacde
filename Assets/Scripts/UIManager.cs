using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;

    private void Awake()
    {
        gameManager.GameStart += HandleGameStart;
        gameManager.GameEnd += HandleGameEnd;
        gameManager.Score += HandleScore;
    }
    private void OnDestroy()
    {
        gameManager.GameStart -= HandleGameStart;
        gameManager.GameEnd -= HandleGameEnd;
        gameManager.Score -= HandleScore;
    }

    public void HandleGameEnd()
    {

    }

    public void HandleGameStart()
    {

    }

    public void HandleScore(int points)
    {
        
    }
}

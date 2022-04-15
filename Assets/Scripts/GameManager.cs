using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameManager : ScriptableObject
{
    public delegate void GameEvent();
    public delegate void GamePointsEvent(int points);
    public event GameEvent GameStart;
    public event GameEvent GameEnd;
    public event GamePointsEvent Score;

    public void TriggerGameEnd()
    {
        if (GameEnd!=null)
        {
            GameEnd();
        }
    }

    public void TriggerGameStart()
    {
        if (GameStart!=null)
        {
            GameStart();
        }
    }
    public void TriggerScore(int points)
    {
        if (Score!=null)
        {
            Score(points);
        }
    }
}

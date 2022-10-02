using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]
public class LeaderBoards : MonoBehaviour
{
    [SerializeField] GameObject LeaderBoard;
    [SerializeField] Text NameText;
    [SerializeField] Text ScoreText;





    private void Update()
    {
        UpdateScoreBoard(LeaderBoard, NameText.text, ScoreText.text);
    }


    void UpdateScoreBoard(GameObject leaderBoard, string Name, string Score)
    {
        this.LeaderBoard = leaderBoard;
        this.NameText.text = Name;
        this.ScoreText.text = Score;
    }
}

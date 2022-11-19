using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attendance : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Text Score;
    private static int ScoreAmount;
    void Start()
    {
        ScoreAmount = 0;
        Score = GetComponent<Text>();
    }
    private void Update()
    {
        Score.text = ScoreAmount.ToString();
    }
    public void AddScore()
    {
        ScoreAmount += 1;
    }
}



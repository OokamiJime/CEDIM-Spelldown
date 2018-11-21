using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int totalStudents;
    public int score;
    public int scoreP1;
    public int scoreP2;

    public void IncreaseTotal ()
    {
        totalStudents++;

    }

    public void IncreaseScore ()
    {
        score++;
    }

    public void IncreaseScoreP1()
    {
        scoreP1++;
    }

    public void IncreaseScoreP2()
    {
        scoreP2++;
    }
    public void DecreaseScoreP1()
    {
        scoreP1--;

    }
    public void DecreaseScoreP2()
    {
        scoreP2--;

    }
}

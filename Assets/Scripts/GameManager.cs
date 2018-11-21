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

    public void P1Increase()
    {
        scoreP1++;
    }

    public void P2Increase()
    {
        scoreP2++;
    }

    public void P1Decrease()
    {
        scoreP1--;
    }
    public void P2Decrease()
    {
        scoreP2--;
    }



}

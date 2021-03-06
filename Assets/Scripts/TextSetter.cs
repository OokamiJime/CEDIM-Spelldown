﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour {

    public Text totalStudentsText;
    public Text scoreText;
    public Text scoreP1Text;
    public Text scoreP2Text;
  

    public GameObject[] rangos;
    public GameObject[] MPrangos;
   

    public void SetScores ()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        gm.totalStudents = gm.totalStudents + 4;
        totalStudentsText.text = gm.totalStudents.ToString("00");
        scoreText.text = gm.score.ToString("00");

        int half = gm.totalStudents / 2;

        if (gm.score < half)
        {
            rangos[4].SetActive(true);
            rangos[5].SetActive(true);
        }

        else
        {
            if (gm.score >= half & gm.score != gm.totalStudents)
            {
                rangos[2].SetActive(true);
                rangos[3].SetActive(true);
            }
            else
            {
                rangos[1].SetActive(true);
                rangos[0].SetActive(true);
            }
        }
    }

    public void MPSetScores()
    {
        GameManager gm = FindObjectOfType<GameManager>();
        scoreP1Text.text = gm.scoreP1.ToString("00");
        scoreP2Text.text = gm.scoreP2.ToString("00");

        
        if (gm.scoreP1 < gm.scoreP2)
        { //player 2 wins
            MPrangos[2].SetActive(true);
            MPrangos[3].SetActive(true);
        }

        else
        {
            if (gm.scoreP1 > gm.scoreP2)
            { //player 1 wins
                MPrangos[0].SetActive(true);
                MPrangos[1].SetActive(true);
            }
            else
            { //tie
                MPrangos[4].SetActive(true);
                MPrangos[5].SetActive(true);
                MPrangos[6].SetActive(true);
            }
        }
    }

}

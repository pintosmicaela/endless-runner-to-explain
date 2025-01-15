using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    private float score;
    [SerializeField] private Text highScore;

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") != null)        
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString(); //Actualizamos el valor
            highScore.text = ((int)score).ToString();
        }
    }
}


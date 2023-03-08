using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
   int score = 0;
    public TMP_Text scoreText;
    public PlayerController player;
    public TMP_Text winText;
   
    
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();

        if ( score == 10)
        {
            winText.text = "You Win!";
            
        }
        Debug.Log("score+1");

    }


}
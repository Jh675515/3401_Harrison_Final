using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkScore();
        ScoreDisplay.text = "Score: " + score;        
    }

    void checkScore()
	{
        

        if (score % 10 == 0 && score != 0)
        {

            image.enabled = true;
        }
		else
		{
            image.enabled = false;

		}
    }


    public void Clicked ()
	{
        score += scorePerClick;
	}

    public UnityEngine.UI.Text ScoreDisplay;
    public int score = 0;
    public int scorePerClick = 1;
    public Image image;
    
}

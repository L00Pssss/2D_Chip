using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    public BoardController boardcontr;
    public Score score;
    private bool timerRunning = true;
    Image timerBar;
    public float maTime = 20f;
    float timeLeft;
    public float TimeLeft;
    public float _Score_Minus;

   


    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maTime;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning == true)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maTime;
        }

        if (boardcontr.boardChips.Count == 0)
        {
            timerRunning = false;
        }





    }
    public void OnEnable()
    {

        
        Invoke("GameOver", TimeLeft);

    }


    void GameOver() {

        if (boardcontr.boardChips.Count != 0)
        {
            score.CountMinus(_Score_Minus);
        }
        else
        {

        }

         

    }  

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
   

    public float score = 0;
    public GameObject ScoretEXT;

    public void Count(GameObject ScoretEXT)
    {
        
        score += 5;
        ScoretEXT.GetComponent<Text>().text = "Score: " + score.ToString();
    }

    public void Update()
    {
        ScoretEXT.GetComponent<Text>().text = "Score: " + score.ToString();
    }

    public void CountMinus(float a)
    {
      //  SceneManager.GetSceneByName("SampleScene");

      //  string sceneName = SceneManager.GetActiveScene().name;

       

      //  if (sceneName == "SampleScene")
     //   {
     
            score -= a;
    //    }
        
    } 


}

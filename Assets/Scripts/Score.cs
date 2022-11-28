using UnityEngine;
using UnityEngine.UI;

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
            score -= a;   
    } 


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideFinishLvl3 : MonoBehaviour
{
    public BoardController boardcontr;
    public Score scores;
    


    public GameObject PanelU;
    public GameObject TextU;

    private void Update()
    {
        Hide();
    }
    public void Hide()
    {
        



        if (boardcontr.boardChips.Count == 0)
        {
            PanelU.SetActive(true);
            if (scores.score == 150)
            TextU.GetComponent<Text>().text = "Congratulations, you got the maximum points !!!";
            else
            TextU.GetComponent<Text>().text = "Congratulations, but you can do better !";
        }
    }





}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BoardController : MonoBehaviour
{
    public Score score;
    public GameObject Text;

    [SerializeField] public List<Chip> boardChips;
    [SerializeField] private List<Sprite> chipSprites;
    private int chipChecked = 0;

    private Chip firstCheckcd;
    private Chip sccondChecked;


    private void Start()
    {
        boardChips = new List<Chip>(GetComponentsInChildren<Chip>());

        for (int i = 0; i < boardChips.Count; i++)
        {
            boardChips[i].boardController = gameObject.GetComponent<BoardController>();
        }

        boardChips = InitRandomPairs(boardChips);
    }
    public void CheckChip(Chip chipFrom)
    {
        if (chipChecked == 0)
        {
            firstCheckcd = chipFrom;
            firstCheckcd.Open();

            chipChecked = 1;
        }
        else if (chipChecked == 1)
        {
            chipFrom.Open();
            if (firstCheckcd.boardNumber == chipFrom.boardNumber && firstCheckcd != chipFrom)
            {
                firstCheckcd.Destroy();
                chipFrom.Destroy();
                score.Count(Text);
            }
            else
            {
                firstCheckcd.Hide();
                chipFrom.Hide();
            }

            

            chipChecked = 0;

        }
    }

    private void Update()
    {
        boardChips = new List<Chip>(GetComponentsInChildren<Chip>());

        for (int i = 0; i < boardChips.Count; i++)
        {
            if (boardChips[i].boardController == null)
            {
                boardChips.Remove(null);
            }

        }
    }




    public List<Chip> InitRandomPairs(List<Chip> inList)
    {
        List<Sprite> openSprites = chipSprites;
        List<Chip> shuffleList = new List<Chip>();

        int count = inList.Count;

        System.Random random = new System.Random();

        for (int i = 0; i < count/2; i++)
        {
            int sprite = random.Next(openSprites.Count);

            shuffleList.Add(inList[0]);
            inList[0].boardNumber = i;
            inList[0].SetOpenImage(openSprites[sprite]);
            inList.RemoveAt(0);

            int pair = random.Next(inList.Count);

            shuffleList.Add(inList[pair]);
            inList[pair].boardNumber = i;
            inList[pair].SetOpenImage(openSprites[sprite]);
            inList.RemoveAt(pair);

            openSprites.RemoveAt(sprite);

           

        }

        //if (boardChips == null)
        //{
        //    boardChips.Remove(null);
        //}




        return shuffleList;
    }
}

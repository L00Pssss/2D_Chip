using UnityEngine;

public class Chip : MonoBehaviour
{
    public int boardNumber;

    public Sprite hideImage;
    public Sprite openImage;


    public BoardController boardController;

    private void OnMouseUpAsButton()
    {
        boardController.CheckChip(gameObject.GetComponent<Chip>()); 
    }

    public void SetOpenImage(Sprite sprite)
    {
        openImage = sprite;
    }

    public void Destroy()
    {
        Destroy(gameObject, 0.1f);
    }

    public void Hide()
    {
        GetComponent<SpriteRenderer>().sprite = hideImage;
    }
    public void Open()
    {
        GetComponent<SpriteRenderer>().sprite = openImage;
    }
}

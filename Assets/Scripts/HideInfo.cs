using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInfo : MonoBehaviour
{
    public GameObject Panel;

    public void Hide()
    {
        Panel.SetActive(true);
    }

    public void Show()
    {
        Panel.SetActive(false);
    }
}

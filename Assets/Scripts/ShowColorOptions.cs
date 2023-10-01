using UnityEngine;

public class ShowColorOptions : MonoBehaviour
{
    public GameObject colorMenu;
    public bool isShowing = false;

    public void ToggleColorMenu()
    {
        if (isShowing)
        {
            colorMenu.SetActive(false);
            isShowing = false;
        }
        else
        {
            colorMenu.SetActive(true);
            isShowing = true;
        }
    }
}

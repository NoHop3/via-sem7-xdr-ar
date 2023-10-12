using UnityEngine;

public class ShowMenuOptions : MonoBehaviour
{
    public GameObject modificationMenu;
    public GameObject colorMenu;
    public bool isColorMenuShowing = false;
    public bool isModificationMenuShowing = false;

    public void ToggleColorMenu()
    {
        if (isColorMenuShowing)
        {
            colorMenu.SetActive(false);
            isColorMenuShowing = false;
        }
        else
        {
            colorMenu.SetActive(true);
            isColorMenuShowing = true;
        }
    }
    public void ToggleModificationMenu()
    {
        if (isModificationMenuShowing)
        {
            modificationMenu.SetActive(false);
            isModificationMenuShowing = false;
        }
        else
        {
            modificationMenu.SetActive(true);
            isModificationMenuShowing = true;
        }
    }
}

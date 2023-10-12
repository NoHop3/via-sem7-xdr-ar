using UnityEngine;

public class ShowMenuOptions : MonoBehaviour
{
    public GameObject modificationSection;
    public GameObject colorSection;
    public bool isColorSectionShowing = false;
    public bool isModificationSectionShowing = false;

    public void ToggleColorMenu()
    {
        if (isColorSectionShowing)
        {
            colorSection.SetActive(false);
            isColorSectionShowing = false;
        }
        else
        {
            colorSection.SetActive(true);
            isColorSectionShowing = true;
        }
    }
    public void ToggleModificationMenu()
    {
        if (isModificationSectionShowing)
        {
            modificationSection.SetActive(false);
            isModificationSectionShowing = false;
        }
        else
        {
            modificationSection.SetActive(true);
            isModificationSectionShowing = true;
        }
    }
}

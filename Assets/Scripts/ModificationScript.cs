using UnityEngine;

public class ModificationScript : MonoBehaviour
{
    public Renderer[] mats;
    public Renderer[] modificationsToPaint;
    private int previousModificationIndex = 0;
    public string modificationSectionName;

    public void ApplyModification(int modificationIndex)
    {
        Debug.Log("ApplyModification called with modificationIndex: " + modificationIndex);
        if (modificationIndex == previousModificationIndex)
        {
            Debug.Log("Modification index is the same as the previous modification index. Returning.");
            return;
        }

        if (modificationIndex < 0 || modificationIndex >= mats.Length)
        {
            Debug.LogError("Modification index is out of range. Returning.");
            return;
        }

        // Hide the previous modification
        mats[previousModificationIndex].gameObject.SetActive(false);

        // Show the new modification
        mats[modificationIndex].gameObject.SetActive(true);

        // Set the previous modification index to the current modification index
        previousModificationIndex = modificationIndex;

    }

    // Add a method to get the modification renderers
    public Renderer[] GetModificationsToPaint()
    {
        return modificationsToPaint;
    }

    // Add a method to get the modification section name
    public string GetModificationSectionName()
    {
        return modificationSectionName;
    }
}

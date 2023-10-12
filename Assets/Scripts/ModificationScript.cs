using UnityEngine;

public class ModificationScript : MonoBehaviour
{
    public GameObject[] modifications;
    public Renderer[] mats;

    private GameObject[] activeModifications;
    private Renderer[] modificationRenderers;

    public void ApplyModification(int modificationIndex)
    {
        if (modificationIndex >= 0 && modificationIndex < modifications.Length)
        {
            GameObject newModification = modifications[modificationIndex];

            for (int i = 0; i < mats.Length; i++)
            {
                // Deactivate the old parts
                activeModifications[i]?.SetActive(false);

                // Activate the new parts
                newModification.SetActive(true);

                // Update the active modifications
                activeModifications[i] = newModification;
            }
        }
    }

    private void Awake()
    {
        activeModifications = new GameObject[mats.Length];
        modificationRenderers = new Renderer[mats.Length];
    }

    // Add a method to get the modification renderers
    public Renderer[] GetModificationRenderers()
    {
        return modificationRenderers;
    }
}

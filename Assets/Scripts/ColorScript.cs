using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Color[] colors;
    private Renderer[] mats;
    private ModificationScript modificationScript;

    public void ChangeColor(int colorIndex)
    {
        if (modificationScript != null)
        {
            Renderer[] modificationRenderers = modificationScript.GetModificationRenderers();

            foreach (Renderer mat in modificationRenderers)
            {
                mat.material.color = colors[colorIndex];
            }
        }
    }

    private void Start()
    {
        // Find the ModificationScript in the scene
        modificationScript = FindObjectOfType<ModificationScript>();
        if (modificationScript == null)
        {
            Debug.LogError("ModificationScript not found in the scene.");
        }
    }
}

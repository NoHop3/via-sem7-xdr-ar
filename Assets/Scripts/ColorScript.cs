using UnityEngine;

public class ColorScript : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;
    private ModificationScript modificationScript;
    private string modificationSectionName;

    public string colorSectionName;

    private void Start()
    {
        // Find the ModificationScript in the scene so we can paint any applied modifications
        modificationScript = FindObjectOfType<ModificationScript>();
        if (modificationScript == null)
        {
            Debug.LogError("ModificationScript not found in the scene.");
        }
    }

    public void ChangeColor(int colorIndex)
    {
        Renderer[] modificationsToPaint = modificationScript.GetModificationsToPaint();
        modificationSectionName = modificationScript.GetModificationSectionName();

        if (modificationSectionName == colorSectionName)
        {
            if(modificationsToPaint.Length >= 0)
            {
                foreach (Renderer mat in modificationsToPaint)
                {
                    mat.material.color = colors[colorIndex];
                }
            }
        }
        if (mats.Length >= 0)
        {
            foreach (Renderer mat in mats)
            {
                mat.material.color = colors[colorIndex];
            }
        }
    }
}

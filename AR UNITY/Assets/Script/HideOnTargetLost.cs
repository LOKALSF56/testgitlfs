using UnityEngine;
using Vuforia;

public class HideOnTargetLost : MonoBehaviour
{
    private Renderer objectRenderer;

    void Start()
    {

        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer != null)
        {
            objectRenderer.enabled = false; 
        }
    }


    public void OnTargetFound()
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = true; 
        }
    }


    public void OnTargetLost()
    {
        if (objectRenderer != null)
        {
            objectRenderer.enabled = false;
        }
    }
}

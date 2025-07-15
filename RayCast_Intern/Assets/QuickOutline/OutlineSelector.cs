using UnityEngine;

public class OutlineSelector : MonoBehaviour
{
    private Outline previousOutline;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject clickedObject = hit.collider.gameObject;
                Outline currentOutline = clickedObject.GetComponent<Outline>();

                if (currentOutline != null)
                {
                    // Disable previous outline
                    if (previousOutline != null)
                    {
                        previousOutline.enabled = false;
                    }

                    // Enable current outline
                    currentOutline.enabled = true;

                    // Store current as previous
                    previousOutline = currentOutline;
                }
            }
        }
    }
}
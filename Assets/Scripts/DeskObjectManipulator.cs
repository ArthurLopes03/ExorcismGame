using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskObjectManipulator : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;
    private SpriteRenderer spriteRenderer;
    public DeskObjectManager deskObjectManager;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(dragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
        spriteRenderer.sortingOrder = deskObjectManager.peak;

        foreach(Transform child in transform)
        {
            try
            {
                SpriteRenderer childSpriteRenderer = child.GetComponent<SpriteRenderer>();

                childSpriteRenderer.sortingOrder = deskObjectManager.peak + 1;
            }
            catch
            { }

            try
            {
                Canvas canvas = child.GetComponent<Canvas>();

                canvas.sortingOrder = deskObjectManager.peak + 1;
            }
            catch { }
        }

        deskObjectManager.peak += 2;
    }

    private void OnMouseUp()
    {
        dragging = false;
    }
}

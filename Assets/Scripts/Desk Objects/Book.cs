using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    int currentPage = 0;
    public List<Sprite> pages;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void NextPage()
    {
        if (currentPage < pages.Count - 1)
        {
            currentPage++;

            spriteRenderer.sprite = pages[currentPage];
        }
    }

    public void LastPage()
    {
        if(currentPage > 0)
        {
            currentPage--;

            spriteRenderer.sprite = pages[currentPage];
        }
    }

    public void GoToPage(int page)
    {
        if (currentPage == 0)
        {
            currentPage = page;

            spriteRenderer.sprite = pages[currentPage];
        }
    }    
}

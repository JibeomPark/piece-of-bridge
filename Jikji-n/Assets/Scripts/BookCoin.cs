using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoin : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private int index;
    private string keyword;

    public void SetKeywordInfo(int n, string text)
    {
        index = n;
        keyword = text;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.SetKeyWordText(index, keyword);
        Destroy(this);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoin : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.SetKeyWordText();
        Destroy(this);
    }
}

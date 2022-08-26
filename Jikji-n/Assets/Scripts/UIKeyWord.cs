using TMPro;
using UnityEngine;

public class UIKeyWord : MonoBehaviour
{
    [SerializeField] private TextMeshPro keywordText;

    public void SetText(string text)
    {
        keywordText.text = text;
    }
}

using System;
using System.Collections.Generic;
using UnityEngine;

public enum Gamephase
{
    None = 0,
    Coin = 1,
    Quiz = 2,
    Dance = 4,
}

[Serializable]
public struct CoinInfo
{
    public int index;
    public string text;
}

[Serializable]
public struct CoinInfoList
{
    public List<CoinInfo> list;
}

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Gamephase> phaseList = new List<Gamephase>();
    [SerializeField] private List<UIKeyWord> keywordList = new List<UIKeyWord>();
    [SerializeField] private List<CoinInfoList> coinInfoList;

    private Gamephase currentPhase = Gamephase.None;
    private int coinStageInfoIndex = 0;
    private int coinInfoIndex = 0;


    void Update()
    {
        switch (currentPhase)
        {
            case Gamephase.Coin:
                {
                    currentPhase = Gamephase.Coin;
                    break;
                }
            case Gamephase.Quiz:
                {
                    currentPhase = Gamephase.Coin;
                    break;
                }
            case Gamephase.Dance:
                {
                    currentPhase = Gamephase.Coin;
                    break;
                }
            case Gamephase.None:
            default:
                {
                    foreach(var keyword in keywordList)
                    {
                        keyword.SetText("");
                    }
                }
                break;

        }
    }

    public void SetPhase(Gamephase phase)
    {
        currentPhase = phase;
    }

    public void SetKeyWordText()
    {
        if (coinStageInfoIndex >= coinInfoList.Count)
            return;

        string keyword = coinInfoList[coinStageInfoIndex].list[coinInfoIndex].text;
        coinInfoIndex++;

        if(coinInfoIndex >= coinInfoList[coinStageInfoIndex].list.Count)
        {
            coinStageInfoIndex++;
            coinInfoIndex = 0;
        }

        keywordList[coinInfoIndex].SetText(keyword);
    }
}

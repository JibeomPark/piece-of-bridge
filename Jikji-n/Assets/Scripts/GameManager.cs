using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Gamephase
{
    None = 0,
    Coin = 1,
    Quiz = 2,
    Dance = 4,

}

public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Gamephase> phaseList = new List<Gamephase>();
    [SerializeField] private List<UIKeyWord> keyWordList = new List<UIKeyWord>();


    private Gamephase currentPhase = Gamephase.None;


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
                break;

        }
    }

    public void SetPhase(Gamephase phase)
    {
        currentPhase = phase;
    }
}

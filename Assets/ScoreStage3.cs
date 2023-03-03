using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreStage3 : MonoBehaviour
{
    public TextMeshProUGUI ScoreShelfTXT;
    public TextMeshProUGUI ScoreBoxTXT;
    public TextMeshProUGUI ScorePhotofameTXT;
    public TextMeshProUGUI SummaryTXT;
    public float score = 100.0f;
    public TriggerScore triggerShelf;
    public TriggerBoxHallway triggerBoxHallway;
    public TriggerPhotofame triggerPhotofame;
    public CashResult cash;

    // Start is called before the first frame update
    void Start()
    {
        summaryScore();
    }
    public void summaryScore()
    {

        if(triggerShelf.triggerShelf == true)
        {
            score -= 15;
            ScoreShelfTXT.text = "-15" ;
        }else{
            ScoreShelfTXT.text = "-0" ;
        }

        if (triggerBoxHallway.triggerBoxHallway == true)
        {
            score -= 5;
            ScoreBoxTXT.text = "-5";

        }else{
            ScoreBoxTXT.text = "-0" ;
        }

        if (triggerPhotofame.triggerPhotofame == true)
        {
            score -= 20;
            ScorePhotofameTXT.text = "-20";

        }else{
            ScorePhotofameTXT.text = "-0" ;
        }
        SummaryTXT.text = score.ToString();
        cash.coins -= score;

        

    }

  
}

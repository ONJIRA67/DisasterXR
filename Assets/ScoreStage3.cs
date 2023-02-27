using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreStage3 : MonoBehaviour
{
    public TextMeshProUGUI ScoreTXT;
    public int score = 100;
    public TriggerScore triggerShelf;
    public TriggerBoxHallway triggerBoxHallway;
    public TriggerPhotofame triggerPhotofame;
    public TriggerObjects triggerTable;

    // Start is called before the first frame update
    public void summaryScore()
    {

        if(triggerShelf == true)
        {
            ScoreTXT.text +="-0\n";
        }else{
            score-= 15;
            ScoreTXT.text +="-15\n";
        }

        if(triggerBoxHallway == true)
        {
            ScoreTXT.text +="-0\n";
        }else{
            score-= 10;
            ScoreTXT.text +="-10\n";
        }

        if(triggerPhotofame == true)
        {
            ScoreTXT.text +="-0\n";
        }else{
            score-= 20;
            ScoreTXT.text +="-20\n";
        }

        if(triggerTable == false)
        {
            ScoreTXT.text +="-0\n";
        }else{
            score+= 20;
            ScoreTXT.text +="+20\n";
        }

    }
}

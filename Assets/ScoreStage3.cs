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

    public void Start()
    {
        ScoreTXT.text = score.ToString();
    }
    // Start is called before the first frame update
    public void summaryScore()
    {

        if(triggerShelf.triggerShelf == true)
        {
            score -= 15;
            ScoreTXT.text = score.ToString() ;
            triggerBoxHallway.triggerBoxHallway = false;
        }

        if (triggerBoxHallway.triggerBoxHallway == true)
        {
            score -= 15;
            ScoreTXT.text = score.ToString();
            triggerPhotofame.triggerPhotofame = false;
        }

        if (triggerPhotofame.triggerPhotofame == true)
        {
            score -= 15;
            ScoreTXT.text = score.ToString();
            triggerShelf.triggerShelf = false;
        }

        if (triggerTable.triggerTable == true)
        {
            score -= 15;
            ScoreTXT.text = score.ToString();
            triggerTable.triggerTable = false;
        }

    }

    private void Update()
    {
        summaryScore();
    }
}

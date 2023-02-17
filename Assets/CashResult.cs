using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class CashResult : MonoBehaviour
{
    public int[,] shopItems = new int[5, 5];
    public float coins;
    public TextMeshProUGUI CoinsTXT;

    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "คงเหลือ:" + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;

        //Price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 20;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;


    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonBuyInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonBuyInfo>().ItemID];
            CoinsTXT.text = "คงเหลือ:" + coins.ToString();
            
        }
        
    }

    public void Sell()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        coins += shopItems[2, ButtonRef.GetComponent<ButtonSellInfo>().ItemID];
        CoinsTXT.text = "คงเหลือ:" + coins.ToString();
    }
}

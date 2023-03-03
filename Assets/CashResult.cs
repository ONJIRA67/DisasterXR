using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class CashResult : MonoBehaviour
{
    public int[,] shopItems = new int[3, 18];
    public float coins;
    public TextMeshProUGUI CoinsTXT;
    public TextMeshProUGUI CoinsTXT2;



    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "คงเหลือ:" + coins.ToString();
        CoinsTXT2.text = "คงเหลือ:" + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;
        shopItems[1, 11] = 11;
        shopItems[1, 12] = 12;
        shopItems[1, 13] = 13;
        shopItems[1, 14] = 14;
        shopItems[1, 15] = 15;
        shopItems[1, 16] = 16;
        shopItems[1, 17] = 17;

        //Price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 7;
        shopItems[2, 3] = 0;
        shopItems[2, 4] = 15;
        shopItems[2, 5] = 7;
        shopItems[2, 6] = 7;
        shopItems[2, 7] = 5;
        shopItems[2, 8] = 5;
        shopItems[2, 9] = 20;
        shopItems[2, 10] = 15;
        shopItems[2, 11] = 10;
        shopItems[2, 12] = 1;   ;
        shopItems[2, 13] = 3;
        shopItems[2, 14] = 2;
        shopItems[2, 15] = 10;
        shopItems[2, 16] = 25;
        shopItems[2, 17] = 20;

    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;


        if (coins >= shopItems[2, ButtonRef.GetComponent<ButtonBuyInfo>().ItemID])
        {
            coins -= shopItems[2, ButtonRef.GetComponent<ButtonBuyInfo>().ItemID];
            CoinsTXT.text = "คงเหลือ:" + coins.ToString();
            CoinsTXT2.text = "คงเหลือ:" + coins.ToString();
            ButtonRef.GetComponent<ButtonBuyInfo>().buyButton.SetActive(false);
            ButtonRef.GetComponent<ButtonBuyInfo>().Items.SetActive(true);
            ButtonRef.GetComponent<ButtonBuyInfo>().sellButton.SetActive(true);
            
            
            
        }
        
    }

    public void Sell()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

            coins += shopItems[2, ButtonRef.GetComponent<ButtonSellInfo>().ItemID];
            CoinsTXT.text = "คงเหลือ:" + coins.ToString();
            CoinsTXT2.text = "คงเหลือ:" + coins.ToString();
            ButtonRef.GetComponent<ButtonSellInfo>().buyButton.SetActive(true);
            ButtonRef.GetComponent<ButtonSellInfo>().sellButton.SetActive(false);
            ButtonRef.GetComponent<ButtonSellInfo>().Items.SetActive(false);
        

    }
}

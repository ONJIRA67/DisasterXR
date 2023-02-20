using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Item = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Item.Add(item);
    }

    public void Remove(Item item)
    {
        Item.Remove(item);
    }

    public void ListItem()
    {
        //Clean content before open.
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }

        foreach(var item in Item)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("Item/ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("Item/ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExistGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(QuitGame);
    }

    private void Update()
    {
        
    }
    void QuitGame()
    {
        Application.Quit();
    }
}

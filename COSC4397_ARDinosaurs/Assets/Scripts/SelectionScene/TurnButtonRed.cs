using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnButtonRed : MonoBehaviour
{
    public Button firstIncorrectButton;
    public Button secondIncorrectButton;
    void Start()
    {
        firstIncorrectButton.onClick.AddListener(firstButtonOnClickHandler);
        secondIncorrectButton.onClick.AddListener(secondButtonOnClickHandler);
    }

    // Update is called once per frame
    void firstButtonOnClickHandler()
    {
        var colors = firstIncorrectButton.colors;
        colors.normalColor = Color.red;
        firstIncorrectButton.colors = colors;
    }

    void secondButtonOnClickHandler()
    {
        var colors = secondIncorrectButton.colors;
        colors.normalColor = Color.red;
        secondIncorrectButton.colors = colors;
    }
}

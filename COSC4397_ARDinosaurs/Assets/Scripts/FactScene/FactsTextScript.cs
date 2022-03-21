using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FactsTextScript : MonoBehaviour
{
    public TextMeshProUGUI firstFact;
    public TextMeshProUGUI secondFact;
    public TextMeshProUGUI thirdFact;

    // Start is called before the first frame update
    void Start()
    {
        firstFact.text = DinosaurInformation.firstFact;
        secondFact.text = DinosaurInformation.secondFact;
        thirdFact.text = DinosaurInformation.thirdFact;
    }
}

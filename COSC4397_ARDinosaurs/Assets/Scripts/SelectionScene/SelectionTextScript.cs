using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectionTextScript : MonoBehaviour
{
    public TextMeshProUGUI firstSelection;
    public TextMeshProUGUI secondSelection;
    public TextMeshProUGUI thirdSelection;
    // Start is called before the first frame update
    void Start()
    {
        firstSelection.text = DinosaurInformation.firstDinosaurName;
        secondSelection.text = DinosaurInformation.secondDinosaurName;
        thirdSelection.text = DinosaurInformation.thirdDinosaurName;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SelectionTextScript : MonoBehaviour
{
    public TextMeshProUGUI firstSelection;
    // Start is called before the first frame update
    void Start()
    {
        firstSelection.text = DinosaurInformation.dinosaurName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

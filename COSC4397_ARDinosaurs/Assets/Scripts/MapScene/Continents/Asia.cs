using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using RSG;
using UnityEngine;

public class Asia : MonoBehaviour
{
    private int continentId = 3;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        DatabaseController.GetContinentInformation(continentId);
    }
}

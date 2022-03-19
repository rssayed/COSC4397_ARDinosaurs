using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using RSG;
using UnityEngine;

public class Europe : MonoBehaviour
{
    private int continentId = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        IPromise<Dictionary<string, List<string>>> promise = DatabaseController.GetContinentInformation(continentId);
        promise.Then(response =>
        {
            Debug.Log("Information: " + JsonConvert.SerializeObject(response));
        });
    }
}

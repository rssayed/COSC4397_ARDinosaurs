using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using RSG;
using UnityEngine;

public class NorthAmerica : MonoBehaviour
{
    private int continentId = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("On Start: ");
        this.gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("North America clicked");
        IPromise<Dictionary<string, List<string>>> promise = DatabaseController.GetContinentInformation(continentId);
        promise.Then(response =>
        {
            Debug.Log("Information: " + JsonConvert.SerializeObject(response));
        });
    }
}

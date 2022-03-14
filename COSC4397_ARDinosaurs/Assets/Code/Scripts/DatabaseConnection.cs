using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DatabaseConnection : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GetContinentInformation();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private Dictionary<string, List<string>> CreateDinosaurInformation(List<DinosaurDTO> continentInformation)
    {
        Dictionary<string, List<string>> dinosaursInformation = new Dictionary<string, List<string>>() { };

        foreach (DinosaurDTO dinosaurInformation in continentInformation)
        {
            if (dinosaursInformation.ContainsKey(dinosaurInformation.dinosaurname))
            {
                dinosaursInformation[dinosaurInformation.dinosaurname].Add(dinosaurInformation.dinosaurfact);
            }
            else
            {
                dinosaursInformation.Add(dinosaurInformation.dinosaurname, new List<string>() { dinosaurInformation.dinosaurfact });
            }
        }

        return dinosaursInformation;
    }

    private void GetContinentInformation()
    {
        RestClient.Get("http://localhost:5000/GetContinentInformation").Then(response => {
            List<DinosaurDTO> continentInformation = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DinosaurDTO>>(response.Text);
            
            Dictionary<string, List<string>> dinosaursInformation = CreateDinosaurInformation(continentInformation);
            Debug.Log(String.Format("Continent: {0}", JsonConvert.SerializeObject(dinosaursInformation)));
        });
    }
}

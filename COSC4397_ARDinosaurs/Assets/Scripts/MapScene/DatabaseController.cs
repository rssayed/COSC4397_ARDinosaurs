using Proyecto26;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using RSG;

[Serializable]
public class DinosaurDTO
{
    public string dinosaurname { get; set; }
    public string dinosaurfact { get; set; }
}
public class DatabaseController
{
    public static Dictionary<string, List<string>> CreateDinosaurInformation(List<DinosaurDTO> continentInformation)
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

    public static IPromise<Dictionary<string, List<string>>> GetContinentInformation(int continentId)
    {
        return RestClient.Get($"http://localhost:5000/GetContinentInformation/{continentId}").Then(response => {
            List<DinosaurDTO> continentInformation = JsonConvert.DeserializeObject<List<DinosaurDTO>>(response.Text);
            Dictionary<string, List<string>> dinosaursInformation = CreateDinosaurInformation(continentInformation);

            return dinosaursInformation;
        });
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Newtonsoft.Json;
using Proyecto26;
using RSG;
using UnityEngine.SceneManagement;

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

    public static void GetContinentInformation(int continentId)
    {
        RestClient.Get($"http://localhost:5000/GetContinentInformation/{continentId}").Then(response => {
            List<DinosaurDTO> continentInformation = JsonConvert.DeserializeObject<List<DinosaurDTO>>(response.Text);
            Dictionary<string, List<string>> dinosaursInformation = CreateDinosaurInformation(continentInformation);

            Debug.Log("Second");

            DinosaurInformation.firstDinosaurName = dinosaursInformation.ElementAt(0).Key;
            DinosaurInformation.secondDinosaurName = dinosaursInformation.ElementAt(1).Key;
            DinosaurInformation.thirdDinosaurName = dinosaursInformation.ElementAt(2).Key;

            DinosaurInformation.firstFact = dinosaursInformation.ElementAt(0).Value[0];
            DinosaurInformation.secondFact = dinosaursInformation.ElementAt(0).Value[1];
            DinosaurInformation.thirdFact = dinosaursInformation.ElementAt(0).Value[2];

            Debug.Log("Second");
            SceneManager.LoadScene(sceneBuildIndex: 2);
        });
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcherButton : MonoBehaviour
{
    public Button thisButton;
    public int nextSceneInteger;
    public void Start()
    {
        Button button = thisButton.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneBuildIndex: nextSceneInteger);
    } 
}

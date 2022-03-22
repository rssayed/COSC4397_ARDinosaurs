using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadButton : MonoBehaviour
{
    public Button thisButton;
    public int sceneInteger;
    // Start is called before the first frame update
    void Start()
    {
        thisButton.onClick.AddListener(SceneSwitch);
    }

    public void SceneSwitch()
    {
        SceneManager.LoadScene(sceneBuildIndex: sceneInteger);
    }
}

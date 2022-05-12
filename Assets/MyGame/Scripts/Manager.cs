using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Hilfsstruktur Aufzählung
public enum MyScenes
{
    WelcomeScene,
    FirstScene,
    SecondScene,
    ThirdScene,
    EndScene
}

public class Manager : MonoBehaviour
{
    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
 public void SwitchTheScene(int x)
    {
        SceneManager.LoadScene(x);
    }

    //Aufruf in Inspector OnClick bei Button, über Name
    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}

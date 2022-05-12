using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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

    public TMP_InputField ipfKidsName;
    public TMP_Text displayKidsName;

    private SoRuntimeData runtimeData;

    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");


        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.FirstScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchTheScene(int x)
    {
        Debug.Log("button pressed, get kidsname " + ipfKidsName.text);


        if (SceneManager.GetActiveScene().buildIndex == (int)MyScenes.WelcomeScene)
        {
            displayKidsName.text = runtimeData.nameKid;
        }

        runtimeData.nameKid = ipfKidsName.text;
        SceneManager.LoadScene(x);
    }

    //Aufruf in Inspector OnClick bei Button, über Name
    public void SwitchTheScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }


}

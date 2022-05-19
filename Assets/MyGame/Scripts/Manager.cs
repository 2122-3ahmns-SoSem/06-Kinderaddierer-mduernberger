using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Hilfsstruktur Aufz�hlung
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

    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");



    }

    //Aufruf in Inspector OnClick bei Button, generisch �ber Parameter
    public void SwitchTheScene(int x)
    {
        runtimeData.nameKid = ipfKidsName.text;
       
        SceneManager.LoadScene(x);
    }




}

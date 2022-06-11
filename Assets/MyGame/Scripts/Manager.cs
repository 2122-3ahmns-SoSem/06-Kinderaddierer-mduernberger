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
    public GameObject flowerBG;
    public GameObject cloudBG;
    public GameObject treeBG;
    public TMP_Text warning;

    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");



    }
    //Hinweis, welches Symbol ausgewählt ist
    public void UseFlower()
    {

        cloudBG.SetActive(false);
        treeBG.SetActive(false);
        if (flowerBG.activeSelf)
        {
            flowerBG.SetActive(false);
        }
        else
        {
            flowerBG.SetActive(true);

        }



    }

    public void UseCloud()
    {

        flowerBG.SetActive(false);
        treeBG.SetActive(false);
        if(cloudBG.activeSelf)
        {
            cloudBG.SetActive(false);
        }
        else
        {
            cloudBG.SetActive(true);
        }
    }

    public void UseTree()
    {

        flowerBG.SetActive(false);
        cloudBG.SetActive(false);
        if (treeBG.activeSelf)
        {
            treeBG.SetActive(false);
        }
        else
        {
            treeBG.SetActive(true);
        }
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchTheScene(int x)
    {
        //Symbol auswählen

        runtimeData.nameKid = ipfKidsName.text;

        if(flowerBG.activeSelf)
        {
            runtimeData.showPic = "flower";
        }
        else if (treeBG.activeSelf)
        {
            runtimeData.showPic = "tree";
        }
        else if (cloudBG.activeSelf)
        {
            runtimeData.showPic = "cloud";
        }
        else
        {
            runtimeData.showPic = "";
        }
        if (runtimeData.showPic == "" && runtimeData.nameKid == "")
        {
            warning.text = "*WÄHLE EIN SYMBOL ODER VERRATE UNS, WIE DU HEISST.";
            warning.fontSize = 30;
            warning.color = Color.red;
           
        }
        else
        {
           SceneManager.LoadScene(x);
        }

    
    }




}

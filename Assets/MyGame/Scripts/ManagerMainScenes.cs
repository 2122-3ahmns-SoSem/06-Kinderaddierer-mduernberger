using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ManagerMainScenes : MonoBehaviour
{

//Hilfsstruktur Aufz�hlung

    
    public TMP_Text displayKidsName;
    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
    }

    //Aufruf in Inspector OnClick bei Button, generisch �ber Parameter
    public void SwitchTheScene(int x)
    {

        SceneManager.LoadScene(x);
    }






}

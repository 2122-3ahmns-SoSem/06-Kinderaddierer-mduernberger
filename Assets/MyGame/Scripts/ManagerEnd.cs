using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEnd : MonoBehaviour
{

    public TMP_Text displayKidsName;
    private SoRuntimeData runtimeData;


    private void Start()
    {
        runtimeData = Resources.Load<SoRuntimeData>("KinderaddiererRuntimeData");

        displayKidsName.text = runtimeData.nameKid;
    }

    //Aufruf in Inspector OnClick bei Button, generisch über Parameter
    public void SwitchTheScene(int x)
    {

        SceneManager.LoadScene(x);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye!");
    }



}

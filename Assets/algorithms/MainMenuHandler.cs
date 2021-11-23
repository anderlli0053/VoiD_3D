

/*
 
Written by Andrew Pozenel AKA SloDevTeam - .:VOID:. - 2020-2022
 
 */



#region Import Directives

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.IO;

#endregion

#region Various functions

public class MainMenuHandler : MonoBehaviour


{
    public Button PlayBTN;
    public Button OptionsBTN;
    public Button AboutBTN;
    public Button ExitBTN;



    // Start is called before the first frame update
    void Start()
    {
        PlayBTN = GameObject.Find("Canvas/Buttons/PlayBTN").GetComponent<Button>();
        OptionsBTN = GameObject.Find("Canvas/Buttons/OptionsBTN").GetComponent<Button>();
        AboutBTN = GameObject.Find("Canvas/Buttons/AboutBTN").GetComponent<Button>();
        ExitBTN = GameObject.Find("Canvas/Buttons/ExitBTN").GetComponent<Button>();


        //PlayBTN.GetComponent<AudioSource>().Play();
        //OptionsBTN.GetComponent<AudioSource>().Play();
        //AboutBTN.GetComponent<AudioSource>().Play();
        //ExitBTN.GetComponent<AudioSource>().Play();



    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    public void ShowOptionsSubmenu()
    {

    }


    public void ShowAboutSubmenu()
    {

        

    }



    public void Exit()
    {
        Application.Quit();
    }


    public void Play()
    {

    }







}


#endregion

using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class LogMeIn : MonoBehaviour
{
    /*public TMP_InputField userNameIn;
    public TMP_InputField passWordIn;
    public string username = "Tasy";
    public string password = "dency";*/
    public Camera mainCamera;

    public TMP_Text output;
    public float networth = 6f;
    public float networthToCheck = 4.5f;
    public bool checkNetworth;
    public TMP_Text errorText;
    

    private void Start()
    {
        //checkNetworth = networth <= networthToCheck;
    }
    public void checkNetwort()
    {

       
        if (networth >= networthToCheck)
    {
            errorText.enabled = true;
            errorText.text = "Welcome to medieval house";
            mainCamera.transform.DOMove(new Vector3(2.0f, 1.7f, -7.2f), 1);
            mainCamera.transform.DORotate(new Vector3(45f, 62f, 0f), 1);
            transform.DOMove(new Vector3(5f, 2f, -6f), 1);
        }
        else
        {
            errorText.enabled = true;
            errorText.text = "Sorry! Come back next time when you're eligible";
        }
    }
}


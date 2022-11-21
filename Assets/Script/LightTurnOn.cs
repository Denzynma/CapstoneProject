using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurnOn : MonoBehaviour

{
    
    public GameObject[] Light;
    public AudioSource AudioClick;
    //public GameObject lightSwitch;
    public bool isLightOff;


    private void OnMouseDown()
    {
        AudioClick.Play();
            if (!isLightOff)
        {
            for (int i = 0; i <= 4; i++)
            {
                Light[i].SetActive(false);
                isLightOff = true;
            }
        }
        else
            {
            for (int i = 0; i <= 4; i++)
            {
                Light[i].SetActive(true);
                isLightOff = false;
            }
        }
      


    }

}
//light[0]= lamp1
//light[1]= lamp2
//light[2]= lamp3
//light[3]= lamp4
// light[i] = lamp i+1, i range 0 to 3, i = i + 1 (i - - means i = i-10

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayGun : MonoBehaviour
{
    public GameObject lmg, smg, shutgun, rifle;

    // Start is called before the first frame update
    void Start()
    {
        string selectedGun = PlayerPrefs.GetString("GUN");

        lmg.SetActive(false);
        smg.SetActive(false);
        shutgun.SetActive(false);
        rifle.SetActive(false);

        if(selectedGun == "R")
        {
            rifle.SetActive(true);
        }
        if (selectedGun == "SMG")
        {
            smg.SetActive(true);
        }
        if (selectedGun == "LMG")
        {
            lmg.SetActive(true);
        }
        if (selectedGun == "S")
        {
            shutgun.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

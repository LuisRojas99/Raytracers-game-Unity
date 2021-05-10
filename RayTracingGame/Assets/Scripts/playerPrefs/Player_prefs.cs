using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_prefs : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        PlayerPrefs.SetInt("Powers",0);
        PlayerPrefs.SetInt("SudokuLives",3);

    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<pongbrick>().getBrickId() ==1) {
            PlayerPrefs.SetInt("Powers",2);
        
        }
        if(this.GetComponent<pongbrick>().getBrickId() == 2)
        {
            PlayerPrefs.SetInt("Powers",1);

        }
    }

    public void powers(int n) {
        if (PlayerPrefs.GetInt("Powers")==1) {
            player.GetComponent<PlayerMovement>().MovementSpeed(10);
        }
        if (PlayerPrefs.GetInt("Powers") == 2)
        {
            player.GetComponent<PlayerMovement>().SetHasgun(true);

        }

    
    }

}

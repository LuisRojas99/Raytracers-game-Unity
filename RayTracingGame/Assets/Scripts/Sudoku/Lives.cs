using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public List<GameObject> errorImages;
    int lives = 0;
    int errorNumber=0;
    // Start is called before the first frame update
    void Start()
    {
        lives = errorImages.Count;
        errorNumber = 0;
    }

    private void wrongNumber() {
        if (errorNumber < errorImages.Count){

            errorImages[errorNumber].SetActive(true);
            errorNumber++;
            lives--;
        }
    }

    private void OnEnable() {
            GameEvents.OnWrongNumber += wrongNumber;
    }


    private void OnDisabled() {
            GameEvents.OnWrongNumber -= wrongNumber;
        
    }
}

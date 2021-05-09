using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public List<GameObject> errorImages;
    int lives = 0;
    int errorNumber=0;
    public GameObject gameOver;
    public GameObject done;
    private int numberOfBlanks = 100;
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
        OutOfLives();
    }
    private void OutOfLives() {

        if (lives <= 0){
        gameOver.SetActive(true);
            lives = 3;
        }
    }

    private void OnEnable() {
            GameEvents.OnWrongNumber += wrongNumber;
    }


    private void OnDisabled() {
            GameEvents.OnWrongNumber -= wrongNumber;
        
    }
    public void decreaseNumberOfBlanks()
    {
        numberOfBlanks--;
    }
    public int getNumberOfBlanks()
    {
        return numberOfBlanks;
    }
    public void setNumberOfBlanks(int n)
    {
        numberOfBlanks = n;
    }
}

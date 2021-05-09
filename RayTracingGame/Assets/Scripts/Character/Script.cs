using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play() {

        SceneManager.LoadScene(1);
    
    }//end of play
    public void goToSudoku() {
        SceneManager.LoadScene(2);
    
    
    }
    
    public void goToPonglike() {

        SceneManager.LoadScene(3);
    }
    
}

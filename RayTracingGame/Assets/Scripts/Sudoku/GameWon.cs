using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameWon : MonoBehaviour
{
    public GameObject Win;
    
    // Start is called before the first frame update
    void Start()
    {
        Win.SetActive(false);
    }
    private void OnBoardCompleted() {
        Win.SetActive(true);
    }
    private void OnEnable() {
        GameEvents.OnBoardCompleted += OnBoardCompleted;
    }
    private void OnDisabled() {
        GameEvents.OnBoardCompleted -= OnBoardCompleted;
    }
   
}

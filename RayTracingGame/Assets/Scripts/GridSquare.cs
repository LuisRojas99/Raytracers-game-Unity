using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class GridSquare : Selectable,IPointerClickHandler,ISubmitHandler, IPointerUpHandler, IPointerExitHandler
{
    public GameObject numberText;
    private int number = 0;
    private bool selected = false;
    private int squareIndex = -1;

    public bool IsSelected() {
        return selected;
    
    }
    public void SetSquareIndex(int index) {
        squareIndex = index; 
    }
    void Start() {

        selected = false;
    }

    public void displayText() {
        if (number <= 0)
        {
            numberText.GetComponent<Text>().text = " ";
        }
        else {
            numberText.GetComponent<Text>().text = number.ToString();
        }

    
    }

    public void SetNumber(int number1) {

        
        number = number1;
        displayText();
    }
    public void OnPointerClick(PointerEventData eventData) {
        selected = true;
        GameEvents.SquareSelectedMethod(squareIndex);
    }
    public void OnSubmit(BaseEventData eventData) { 
        
    }

    private void OnEnable() {
        GameEvents.OnUpdateSquareNumber += OnSetNumber;
        GameEvents.OnSquareSelected += OnSquareSelected;
    }
    private void OnDisabled() {
        GameEvents.OnUpdateSquareNumber -= OnSetNumber;
        GameEvents.OnSquareSelected -= OnSquareSelected;
    }
    public void OnSetNumber(int number) {
        if (selected) {
            SetNumber(number);
        
        }
    }

    public void OnSquareSelected(int squareIndex1) {
        if (squareIndex != squareIndex1) {
            selected = false;
        }
    
    }
}

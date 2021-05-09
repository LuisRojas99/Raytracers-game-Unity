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
    private int correctNumber = 0;
    public bool hasDefaultNumber = false;
    public bool isCorrectNumber() {
        return number == correctNumber;
    }
    public void SetHasDefaultNumber(bool m) {
        hasDefaultNumber = m;
    }
    public bool GetHasDefaultNumber() {

        return hasDefaultNumber;
    }
    public bool IsSelected() {
        return selected;
    
    }
    public void SetSquareIndex(int index) {
        squareIndex = index; 
    }
    public void SetCorrectNumber(int number){

        correctNumber = number;

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
        if (selected && this.number!=correctNumber) {
            SetNumber(number);
            if (number != correctNumber)
            {
                var colors = this.colors;
                colors.normalColor = Color.red;
                this.colors = colors;

                GameEvents.OnWrongNumberMethod();
            }
            else {
                SetHasDefaultNumber(true);
                var colors = this.colors;
                colors.normalColor = Color.green;
                this.colors = colors;
                
            }

        }
    }

    public void OnSquareSelected(int squareIndex1) {
        if (squareIndex != squareIndex1) {
            selected = false;
        }
    
    }
    
}

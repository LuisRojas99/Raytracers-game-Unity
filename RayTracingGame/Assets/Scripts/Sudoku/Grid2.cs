using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid2 : MonoBehaviour
{
    public int columns = 0;
    public int rows = 0;
    public GameObject grid_square;
    public float allSquareOffset = 0.0f;
    public Vector2 startPosition = new Vector2(0.0f, 0.0f);
    private List<GameObject> grid_squares = new List<GameObject>();
    public float SquareScale = 1.0f;
    private int selectedGridData = -1;


    // Start is called before the first frame update
    void Start()
    {
        if (grid_square.GetComponent<GridSquare>() == null) {

            Debug.LogError("grid_square object need to have GridSquare script attached");
        }
        CreateGrid();
        SetGridNumber();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateGrid() {
        SpawnGridSquares();
        SetSquaresPosition();
    }
    private void SpawnGridSquares() {

        int squareIndex = 0;
        for (int row = 0; row < rows; row++) {
            for (int column = 0; column < columns; column++) {
                grid_squares.Add(Instantiate(grid_square) as GameObject);
                grid_squares[grid_squares.Count - 1].GetComponent<GridSquare>().SetSquareIndex(squareIndex);
                grid_squares[grid_squares.Count - 1].transform.parent = this.transform; // instantiate object as child of obkect holding this script
                //grid_squares[grid_squares.Count - 1].SetParent(this.transform);


                grid_squares[grid_squares.Count - 1].transform.localScale = new Vector3(SquareScale, SquareScale, SquareScale);
                squareIndex++;
            }
        
        }
    
    
    }//
    private void SetSquaresPosition() {
        var squareRect = grid_squares[0].GetComponent<RectTransform>();
        Vector2 offset = new Vector2();
        offset.x = squareRect.rect.width * squareRect.transform.localScale.x + allSquareOffset;
        offset.y = squareRect.rect.height * squareRect.transform.localScale.y + allSquareOffset;
        int columnNumber = 0;
        int rowNumber    = 0;
        foreach (GameObject square in grid_squares) {
            if (columnNumber + 1 > columns) {
                rowNumber++;
                columnNumber = 0;

            }
            var posXOffset = offset.x * columnNumber;
            var posYOffset = offset.y * rowNumber;
            square.GetComponent<RectTransform>().anchoredPosition = new Vector3(startPosition.x + posXOffset, startPosition.y-posYOffset);
            columnNumber++;
        }
    
    }
    /*
    private void SetGridNumber( string level) {
        selectedGridData = Random.Range(0, SudokuData.Instance.sudokuGame[level].Count);
        var data = SudokuData.Instance.sudokuGame[level][selectedGridData];

        setGridSquareData(data);
    }
    */
    private void SetGridNumber() {
        int[] sudoku1 = new int[81] { 0, 2, 7, 0, 5, 4, 3, 0, 6,
                          9, 6, 0, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 0, 7, 0, 0,
                          5, 0, 3, 0, 6, 8, 2, 7, 1,
                          4, 0, 2, 5, 1, 3, 0, 8, 9,
                          6, 1, 8, 0, 7, 2, 4, 3, 0,
                          7, 8, 6, 2, 3, 0, 9, 1, 4,
                          1, 0, 4, 0, 9, 6, 8, 0, 3,
                          2, 3, 0, 8, 4, 1, 5, 6, 7 };
        int[] sudoku2 = new int[81]{ 8, 2, 7,   1, 5, 4,   3, 9, 6,
                                     9, 6, 5,   3, 2, 7,   1, 4, 8,
                                     3, 4, 1,   6, 8, 9,   7, 5, 2,

                                     5, 9, 3,   4, 6, 8,   2, 7, 1,
                                     4, 7, 2,   5, 1, 3,   6, 8, 9,
                                     6, 1, 8,   9, 7, 2,   4, 3, 5,

                                     7, 8, 6,   2, 3, 5,   9, 1, 4,
                                     1, 5, 4,   7, 9, 6,   8, 2, 3,
                                     2, 3, 9,   8, 4, 1,   5, 6, 7 };
        for (int index = 0; index < 81; index++)
        {
            //grid_squares[index].GetComponent<GridSquare>().SetNumber(data.unsolvedData[index]);
            grid_squares[index].GetComponent<GridSquare>().SetNumber(sudoku1[index]);
            grid_squares[index].GetComponent<GridSquare>().SetCorrectNumber(sudoku2[index]);
        }

    }
    private void setGridSquareData(SudokuData.SudokuBoardData data) {
        int[] sudoku1 =new int[81] { 0, 2, 7, 0, 5, 4, 3, 0, 6,
                          9, 6, 0, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 0, 7, 0, 0,
                          5, 0, 3, 0, 6, 8, 2, 7, 1,
                          4, 0, 2, 5, 1, 3, 0, 8, 9,
                          6, 1, 8, 0, 7, 2, 4, 3, 0,
                          7, 8, 6, 2, 3, 0, 9, 1, 4,
                          1, 0, 4, 0, 9, 6, 8, 0, 3,
                          2, 3, 0, 8, 4, 1, 5, 6, 7 };

        int[] sudoku2 = new int[81]{ 8, 2, 7,   1, 5, 4,   3, 9, 6,
                                     9, 6, 5,   3, 2, 7,   1, 4, 8,
                                     3, 4, 1,   6, 8, 9,   7, 5, 2,

                                     5, 9, 3,   4, 6, 8,   2, 7, 1,
                                     4, 7, 2,   5, 1, 3,   6, 8, 9,
                                     6, 1, 8,   9, 7, 2,   4, 3, 5,
                                     
                                     7, 8, 6,   2, 3, 5,   9, 1, 4,
                                     1, 5, 4,   7, 9, 6,   8, 2, 3,
                                     2, 3, 9,   8, 4, 1,   5, 6, 7 };
        for (int index = 0; index < 81; index++) {
            //grid_squares[index].GetComponent<GridSquare>().SetNumber(data.unsolvedData[index]);
            grid_squares[index].GetComponent<GridSquare>().SetNumber(sudoku1[index]);
            grid_squares[index].GetComponent<GridSquare>().SetCorrectNumber(sudoku2[index]);
        }
        
    }

}

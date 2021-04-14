using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuEasy : MonoBehaviour {
    public static List<SudokuData.SudokuBoardData> getData() {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 2, 7, 0, 5, 4, 3, 0, 6,
                          9, 6, 0, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 0, 7, 0, 0,
                          5, 0, 3, 0, 6, 8, 2, 7, 1,
                          4, 0, 2, 5, 1, 3, 0, 8, 9,
                          6, 1, 8, 0, 7, 2, 4, 3, 0,
                          7, 8, 6, 2, 3, 0, 9, 1, 4,
                          1, 0, 4, 0, 9, 6, 8, 0, 3,
                          2, 3, 0, 8, 4, 1, 5, 6, 7 },
            //solved data
            new int[81] { 8, 2, 7, 1, 5, 4, 3, 9, 6,
                          9, 6, 5, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 9, 7, 5, 2,
                          5, 9, 3, 4, 6, 8, 2, 7, 1,
                          4, 7, 2, 5, 1, 3, 6, 8, 9,
                          6, 1, 8, 9, 7, 2, 4, 3, 5,
                          7, 8, 6, 2, 3, 5, 9, 1, 4,
                          1, 5, 4, 7, 9, 6, 8, 2, 3,
                          2, 3, 9, 8, 4, 1, 5, 6, 7 }
            ));
        return data;
    
    }

}
public class SudokuMedium : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 2, 7, 0, 5, 4, 3, 0, 6,
                          9, 6, 0, 3, 2, 7, 1, 4, 8,
                          3, 0, 1, 6, 8, 0, 7, 0, 0,
                          5, 0, 3, 0, 6, 8, 2, 7, 1,
                          4, 0, 2, 0, 0, 3, 0, 8, 9,
                          6, 1, 8, 0, 7, 2, 4, 3, 0,
                          7, 8, 6, 2, 3, 0, 9, 1, 4,
                          1, 0, 4, 0, 0, 0, 8, 0, 3,
                          2, 3, 0, 8, 4, 1, 5, 6, 7 },
            //solved data
            new int[81] { 8, 2, 7, 1, 5, 4, 3, 9, 6,
                          9, 6, 5, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 9, 7, 5, 2,
                          5, 9, 3, 4, 6, 8, 2, 7, 1,
                          4, 7, 2, 5, 1, 3, 6, 8, 9,
                          6, 1, 8, 9, 7, 2, 4, 3, 5,
                          7, 8, 6, 2, 3, 5, 9, 1, 4,
                          1, 5, 4, 7, 9, 6, 8, 2, 3,
                          2, 3, 9, 8, 4, 1, 5, 6, 7 }
            ));
        return data;

    }

}
public class SudokuHard : MonoBehaviour
{
    public static List<SudokuData.SudokuBoardData> getData()
    {
        List<SudokuData.SudokuBoardData> data = new List<SudokuData.SudokuBoardData>();
        data.Add(new SudokuData.SudokuBoardData(
            new int[81] { 0, 2, 7, 0, 5, 4, 3, 0, 6,
                          9, 6, 0, 3, 0, 7, 1, 4, 8,
                          3, 0, 1, 6, 8, 0, 7, 0, 0,
                          0, 0, 3, 0, 6, 0, 2, 0, 1,
                          4, 0, 2, 0, 0, 3, 0, 8, 9,
                          0, 1, 8, 0, 7, 2, 4, 3, 0,
                          7, 8, 6, 2, 3, 0, 9, 1, 4,
                          1, 0, 4, 0, 0, 0, 8, 0, 3,
                          0, 3, 0, 8, 4, 1, 5, 6, 7 },
            //solved data
            new int[81] { 8, 2, 7, 1, 5, 4, 3, 9, 6,
                          9, 6, 5, 3, 2, 7, 1, 4, 8,
                          3, 4, 1, 6, 8, 9, 7, 5, 2,
                          5, 9, 3, 4, 6, 8, 2, 7, 1,
                          4, 7, 2, 5, 1, 3, 6, 8, 9,
                          6, 1, 8, 9, 7, 2, 4, 3, 5,
                          7, 8, 6, 2, 3, 5, 9, 1, 4,
                          1, 5, 4, 7, 9, 6, 8, 2, 3,
                          2, 3, 9, 8, 4, 1, 5, 6, 7 }
            ));
        return data;

    }

}



public class SudokuData : MonoBehaviour
{
    public static SudokuData Instance;
    public struct SudokuBoardData {
        public int[] unsolvedData;
        public int[] solvedData;
        public SudokuBoardData(int[] unsolved, int[] solved ):this() {

            this.unsolvedData = unsolved;
            this.solvedData = solved;

        }
    
    };

    public Dictionary<string, List<SudokuBoardData>> sudokuGame = new Dictionary<string, List<SudokuBoardData>>();
    void Awake() { 
        if(Instance == null)
        {
            Instance = this;
        }
        Destroy(this);
    }

    void Start() {

        sudokuGame.Add("Easy", SudokuEasy.getData());
        sudokuGame.Add("Medium", SudokuMedium.getData());
        sudokuGame.Add("Hard", SudokuHard.getData());
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ScriptMain : MonoBehaviour
{
    public Material[] materialArray;
    public GameObject[] gamefield;

    public int check;

    private int modeSelect; // Режим игры
    public int moveSelect; // Ход(Х,О)
    private int difficultySelect; // Сложность
    private int moveCounter;

    private GameField gameField; 


    // Start is called before the first frame update
    void Start()
    {
        gameField = new GameField(gamefield);

        for (int i = 0; i < 9; i++)
        {
            gameField.GetField(i).GetComponent<MeshRenderer>().material = materialArray[0];
        } 
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void ChangeMoveSelect()
    {
        switch(moveSelect)
        {
            case 1:
                moveSelect = 2;
                break;
            case 2:
                moveSelect = 1;
                break;
        }
    }

    private int checkWin()
    {
        int countX = 0, countO = 0, count = 0;

        for (int i = 0; i < 9; i++) 
        {
            if (gameField.GetField(i).GetComponent<MeshRenderer>().sharedMaterial == materialArray[1])
            {
                countX++;        
            }
            else
            if (gameField.GetField(i).GetComponent<MeshRenderer>().sharedMaterial == materialArray[2])
            {
                countO++;
            }
            count++;
            UnityEngine.Debug.Log(countX);
            if (countO == 3)
            {
                return 2;
            }
            if (countX == 3)
            {
                return 1;
            }

            if(count == 3)
            {
                countX = 0;
                countO = 0;
                count = 0;
            }
          
        }
        return 0;

    }

    public void ModeSelect(int i)
    {
        modeSelect = i;
    }

    public void MoveSelect(int i)
    {
        moveSelect = i;
    }

    public void DifficultySelect(int i)
    {
        difficultySelect = i;
    }

    public void ClickOnField(GameObject gameObject)
    {
        Material material;
        material = gameField.GetField(gameObject).GetComponent<MeshRenderer>().sharedMaterial;

        if (material == materialArray[0])
        {
            gameObject.GetComponent<MeshRenderer>().material = materialArray[moveSelect];
            moveCounter++;
            
            if(moveCounter > 5)
            {
                int check = checkWin();
                if (check == 1)
                    UnityEngine.Debug.Log("Выиграл Х");
                else
                if(check == 2)
                    UnityEngine.Debug.Log("Выиграл O");

            }
            if (moveCounter == 9)
            {
                UnityEngine.Debug.Log("Игра окончена");
            }

            ChangeMoveSelect();
        }
        else 
        {
            UnityEngine.Debug.Log("Занято");
        }

    }

    public void test(int i)
    {
        i++;
    }

    public class GameField
    {
        private GameObject[] gamefield;

        public GameField(GameObject[] gamefield)
        {
            this.gamefield = gamefield;

        }

        public GameObject GetField(int i)
        {
            return gamefield[i];
        }

        public GameObject GetField(GameObject gameObject)
        {
            for(int i = 0; i < 9; i++)
            {
                if (gamefield[i] == gameObject)
                    return gamefield[i];
            }
            return null;
        }

    }

    public class Player
    {
        private bool flag;
        private char symbol;
        private string outputText;

        public Player(bool flag, char symbol, string outputText)
        {
            this.flag = flag;
            this.symbol = symbol;
            this.outputText = outputText;
        }

        public bool GetFlag()
        {
            return this.flag;
        }

        public char GetSympol()
        {
            return this.symbol;
        }

        public string GetOutputText()
        {
            return this.outputText;
        }

    }

}



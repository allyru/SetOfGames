using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ScriptMain : MonoBehaviour
{
    public Material[] materialArray;
    public GameObject[] gamefield;

    public int modeSelect;
    private bool currentMove;
    // Start is called before the first frame update
    void Start()
    {
        GameField gameField = new GameField(gamefield);
        for (int i = 0; i < 9; i++)
        {
            gameField.GetField(i).GetComponent<MeshRenderer>().material = materialArray[0];
        } 


    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ModeSelect(int i)
    {
        modeSelect = i;
        UnityEngine.Debug.Log(modeSelect);
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



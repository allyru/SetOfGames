using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenuControl : MonoBehaviour
{
    public void PlayGameTicTacToe()
    {
        SceneManager.LoadScene("TIC TAC toe game");
    }

}

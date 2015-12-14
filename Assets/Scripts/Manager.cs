using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

enum gameState
{
    START = 0,
    RUN = 1,
    END = 2
}

public class Manager : MonoBehaviour {

    public int game_status;
    public bool player_human;
    public int score_j1;
    public int score_j2;
    public Dictionary<int, int> map;

    public GameObject startMenu;
    public GameObject mainUI;
    public GameObject gameoverMenu;

    private int taken_pawns_human;
    private int taken_pawns_ia;

    // Use this for initialization
    void Start () {
        game_status = 0;
        score_j1 = 0;
        score_j2 = 0;
        player_human = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        startMenu.SetActive(false);
        mainUI.SetActive(true);
        game_status = 1;
    }

    void GameOver()
    {
        game_status = 2;
        mainUI.SetActive(false);
        gameoverMenu.SetActive(true);
    }

    public void Restart()
    {SceneManager.LoadScene("Giban");}

    public void Pass()
    {player_human = !player_human;}

    public void takePawn(int x, int y, bool human)
    {
    }
}

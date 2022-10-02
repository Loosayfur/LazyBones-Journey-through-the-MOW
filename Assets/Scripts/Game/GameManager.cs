using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameManager instance;
    private GameMode gameMode;
    [SerializeField]private Player[] players;
    [SerializeField] private List<Player> playersInLobby;
    [SerializeField] private List<Player> playersAlive;
    [SerializeField] private Enemies[] enemies;
    [SerializeField] private Enemies Enemy;
    [SerializeField] private Player player;
    [SerializeField] private float roundTimer = 300f;
    [SerializeField] private float roundStartTimer = 15f;
    [SerializeField] private bool roundOver = false;
    [SerializeField] private float roundEndTimer = 5;
    [SerializeField] public int[] Team = new int[2];
    [SerializeField] public int[] playerKills;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text playerName;
    [SerializeField] private GameObject enemySpawnZone;
    [SerializeField] private GameObject SpawnerEnemy;
    private int Score;
    public GameObject lobbyLeaderBoard;
    public GameObject gameStats;
    public Scene[] easyMaps;
    public Scene[] mediumMaps;
    public Scene[] hardMaps;
    public Scene[] extremeMap;
    public GameObject Radar;
    



    // Start is called before the first frame update
    void Start()
    {
        
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        for (int i = 0; i < players.Length; i++)
        {
            players[i] = player;
        }
        AddPlayers();
    }

    // Update is called once per frame
    void Update()
    {

        if(player.Health <= 0)
        {
            playersAlive.Remove(player);
        }
        if (roundTimer <= 0)
        {
            roundOver = true;
        }
        if (playersAlive.Count <= 0)
        {
            roundOver = true;
            if (roundOver)
            {
                lobbyLeaderBoard.SetActive(true);
                SceneManager.LoadScene("Lobby");
            }
        }
        
        if(!roundOver)
        {
            StartCoroutine(SpawnEnemy(3, Enemy.gameObject));
            for (int i = 0; i < enemies.Length; i++)
            {
                Enemy = enemies[i];
                if (enemies.Length >= 200)
                {
                    StopCoroutine("SpawnEnemy");
                }
            }
            
        }

    }

    private IEnumerator SpawnEnemy(float delay, GameObject Enemy)
    {
        delay = 3f;
        yield return new WaitForSeconds(delay);
        GameObject newEnemy = Instantiate(Enemy);
        StartCoroutine(SpawnEnemy(delay, Enemy));
        
    }


    private void AddPlayers()
    {
        for (int i = 0; i < players.Length; i++)
        {

            playersInLobby.Add(players[i]);
            foreach (Player player in playersInLobby)
            {
                playersAlive.Add(player);
            }
        }
    }
}

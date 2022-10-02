using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



[System.Serializable]
public class Player : MonoBehaviour
{
    public Player player;
    public string Name;
    [SerializeField]
    private InputField inputField;
    public int Kills;
    public float spawnTime;
    public int Money;
    public double infectionPercent;
    public float maxHealth;
    public float Health;
    public float moveSpeed;
    public float swingDelay;
    public enemyType EnemyForm;
    public static bool enemyIsLocked;
    private bool isAlive;
    public GameObject currentTarget;
    [SerializeField] private PlayerInventory inventory;
    
    void Start()
    {
        Name = null;
        this.tag = "Player";
        inputField.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Name == null)
        {
           
            print("What is your Name?");
            {
                if (inputField.text != null)
                {
                    Name = inputField.text;
                    if (inputField.text == "")
                    {
                        Name = inputField.text;
                    }
                }
            }
        }

        
        
    }

    public GameObject Die()
    {
        if(this.Health <= 0)
        {
            gameObject.SetActive(false);
            this.tag = "Zombie";
            if(tag == "Zombie")
            {
                
            }
        }
        return gameObject;
    }

    public void Respawn()
    {
        switch (EnemyForm)
        {
            case enemyType.Normal:
                if(Kills <= 15)
                {
                    player.EnemyForm = enemyType.Normal;
                }
                break;
            case enemyType.Brute:
                if (Kills == 16||Kills <= 30 )
                {
                    player.EnemyForm = enemyType.Brute;
                }
                break;
            case enemyType.Dog:
                break;
            case enemyType.Bird:
                break;
            case enemyType.Toad:
                break;
            case enemyType.Boss1:
                break;
            case enemyType.Boss2:
                break;
            case enemyType.Boss3:
                break;
            default:
                break;
        }
        Instantiate(player);   
    }

    public GameObject Zombie(Player player, enemyType enemyForms)
    {
        
        return player.gameObject; 
    }

}

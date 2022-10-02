using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum enemyType
{
    Normal,
    Brute,
    Dog,
    Bird,
    Toad,
    Boss1,
    Boss2,
    Boss3,

}
public abstract class Enemies : MonoBehaviour
{
    public string enemyName;
    public float enemySpeed;
    public GameObject enemyPrefab;
    public double infectionInfliction;
    public int killsRequired;
    public int Health;
    public int maxHealth;
    public int Power;
    public float spawnDelay;
    public bool isFlying = false;
    public enemyType Type;
    public Player Target;
    bool playerInRange = false;

    public void Die()
    {
        if(this.Health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }

    void ChaseTarget()
    {
       var chaseSpeed = enemySpeed * Time.deltaTime;
        if(Target.transform.position != this.transform.position)
        {
            Vector3.MoveTowards(transform.position, Target.transform.position,chaseSpeed);
        }
        if (playerInRange)
        {
            Attack(Power);
        }
    }

    public void Attack(int amount)
    {
        Player player = gameObject.GetComponent<Player>();
        player.Health -= amount;
        player.infectionPercent += infectionInfliction;
    }
    
    

}

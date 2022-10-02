using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : Enemies
{

    private void Start()
    {
        enemyName = "Crow";
        enemySpeed = 2.5f;
        infectionInfliction = .02d;
        maxHealth = 60;
        isFlying = true;
        Type = enemyType.Bird;
    }


}

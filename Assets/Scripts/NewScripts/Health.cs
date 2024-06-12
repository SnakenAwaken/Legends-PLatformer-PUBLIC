using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float MaxHealth;
    public float CurrentHealth;
    public int Coins;

    public float QDMG; // Queried Damage
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(QDMG != 0)
        {
            CurrentHealth = CurrentHealth - QDMG;
            QDMG = 0;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    [Tooltip("The particles that appear after the player collects a coin.")]
    public GameObject coinParticles;
    public float Heal;
    public int GetReady;
    Health Health;

    PlayerMovement playerMovementScript;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerMovementScript = other.GetComponent<PlayerMovement>();
            playerMovementScript.soundManager.PlayCoinSound();
            ScoreManager.score += 10;
            GameObject particles = Instantiate(coinParticles, transform.position, new Quaternion());
            Health = other.gameObject.GetComponent<Health>();
            Health.Coins ++;
            if(Health.Coins > 10)
            {
                Health.QDMG = Heal;
                Health.Coins = 0;
            }
            Destroy(gameObject);
        }
    }
}
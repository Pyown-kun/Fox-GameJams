using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPlush : MonoBehaviour
{
    [SerializeField] private int energyAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Player")
        {
            CoinFlipping coinFlipping = collision.GetComponent<CoinFlipping>();
            coinFlipping.AddEnergy(energyAmount);
            Destroy(gameObject);
        }
    }
}

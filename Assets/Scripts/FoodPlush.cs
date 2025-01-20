using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlush : MonoBehaviour
{
    [SerializeField] private int foodAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FoodManager foodManager = collision.GetComponent<FoodManager>();
            foodManager.AddFood(foodAmount);
            Destroy(gameObject);
        }
    }
}

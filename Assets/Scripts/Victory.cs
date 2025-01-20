using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FoodManager foodManager = collision.gameObject.GetComponent<FoodManager>();

            if (foodManager.FoodAmount == 5)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}

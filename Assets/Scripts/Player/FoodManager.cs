using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodManager : MonoBehaviour
{
    public Text FoodText;

    public int FoodAmount;

    private void Update()
    {
        FoodText.text = FoodAmount + " / 5";
    }

    public void AddFood(int foodPlus)
    {
        FoodAmount += foodPlus;
    }
}

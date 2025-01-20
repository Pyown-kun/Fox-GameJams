using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CoinFlipping : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public GameObject CoinCanWalk;
    public GameObject CoinCanNotWalk;
    public Animator CoinHeadFlip;
    public Animator CoinTailFlip;

    public Text EnergyText;

    [SerializeField] private int energy = 4;

    private int coinResult;


    private void Update()
    {
        EnergyText.text = energy.ToString(); 
        
        if (energy < 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void CoinFlip()
    {
        --energy;
        coinResult = Random.Range(0, 2);

        StartCoroutine(FLipAnimation());

        if (coinResult == 0)
        {
            PlayerMovement.IsMoveing = true;
            CoinCanWalk.SetActive(true);
            CoinCanNotWalk.SetActive(false);
        }
        else
        {
            CoinCanWalk.SetActive(false);
            CoinCanNotWalk.SetActive(true);
        }

        
        Debug.Log(coinResult);
    }

    public IEnumerator FLipAnimation()
    {
        CoinHeadFlip.SetBool("isFlip", true);
        CoinTailFlip.SetBool("isFlip", true);

        yield return new WaitForSeconds(0.4f);

        CoinHeadFlip.SetBool("isFlip", false);
        CoinTailFlip.SetBool("isFlip", false);
    }

    public void AddEnergy(int energyAmount)
    {
        energy += energyAmount;
    }
}

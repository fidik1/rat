using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    public static int balance;
    public Text balanceText;
    void Start()
    {
        balance = PlayerPrefs.GetInt("balance", 0);
        StartCoroutine(UpdateBalance());
    }

    IEnumerator UpdateBalance()
    {
        while (true)
        {
            balanceText.text = balance.ToString();
            yield return new WaitForSeconds(0.5f);
        }
    }
}

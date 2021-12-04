using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMain : MonoBehaviour
{
    public GameObject[] gameObjects;
    public GameObject[] furniture;
    private void Start()
    {

    }

    public void Play()
    {

    }

    public void Buttons(int numButton)
    {
        if (gameObjects[numButton].activeInHierarchy)
            gameObjects[numButton].SetActive(false);
        else
            gameObjects[numButton].SetActive(true);
    }

    public void BuyFurniture(int numFurniture)
    {
        furniture[numFurniture].SetActive(true);
    }
}

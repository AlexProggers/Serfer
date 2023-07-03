using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController I;
	
	public int Coin;
	
	public TextMeshProUGUI coinText;
	
	public GameObject cubePrefab;
	
	public PlayerController Player;
	
    void Awake()
    {
		Coin = 0;
        I = this;
    }
	
	void Update()
	{
		
		coinText.text = "Coin : " + Coin;
	}
}

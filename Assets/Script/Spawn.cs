using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject Coin;
	public static int numberCoins = (int)System.Math.Ceiling(Random.value * 100);
	// Use this for initialization
	void Start () {
		for (int i = 0; i < numberCoins; i++) {
			Instantiate(Coin);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}



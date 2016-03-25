using UnityEngine;
using System.Collections;

public class CoinBehavior : MonoBehaviour {
	// Use this for initialization
	public AudioClip coin;


	void Start () {
		transform.position = new Vector3(Random.Range(-50, 50),2, Random.Range(-50, 50));	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,0,100) * Time.deltaTime);

	}

	void OnTriggerEnter( Collider collider ) {
		switch (collider.gameObject.name) {
		case("PlayerBlue"):
			AudioSource.PlayClipAtPoint(coin, transform.position);
			CoinCollecting.playerBlue += 1;
			CoinCollecting.totalCount += 1;
			Destroy (this.gameObject);
			break;
	
		case("PlayerBlue1"):
			AudioSource.PlayClipAtPoint(coin, transform.position);
			Destroy (this.gameObject);
			CoinCollecting.playerBlue += 1;
			CoinCollecting.totalCount += 1;
			break;
		
		case("PlayerRed"):
			AudioSource.PlayClipAtPoint(coin, transform.position);
			Destroy (this.gameObject);
			CoinCollecting.playerRed += 1;
			CoinCollecting.totalCount += 1;
			break;

		case("PlayerRed1"):
			AudioSource.PlayClipAtPoint(coin, transform.position);
			Destroy (this.gameObject);
			CoinCollecting.playerRed += 1;
			CoinCollecting.totalCount += 1;
			break;


	}
	}
}





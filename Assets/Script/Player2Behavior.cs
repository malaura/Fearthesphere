using UnityEngine;
using System.Collections;

public class Player2Behavior : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 10;
		float moveHorizontal = Input.GetAxis ("Horizontal2");
		float moveVertical = Input.GetAxis ("Vertical2");
		Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce(move * speed);
	
	}
}

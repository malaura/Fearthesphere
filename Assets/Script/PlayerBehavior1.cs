using UnityEngine;
using System.Collections;

public class PlayerBehavior1 : MonoBehaviour {

		private Rigidbody rb;
		public float speed;

		// Use this for initialization
		void Start () {
			rb = GetComponent<Rigidbody> ();

		}

		// Update is called once per frame
		void Update () {
			float speed = 10;
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");
			Vector3 move = new Vector3 (moveHorizontal, 0, moveVertical);
			rb.AddForce(move * speed);

		}


}

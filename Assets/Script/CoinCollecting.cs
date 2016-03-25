using UnityEngine;
using System.Collections;

public class CoinCollecting : MonoBehaviour {
	public static int playerBlue = 0;
	public static int playerRed = 0;
	public static int totalCount = 0;
	public string overText;



	void OnGUI()
	{	

		string coinText1 = "Red Coins: " + playerRed;
		GUI.Box(new Rect(0, 20, 130, 40), coinText1);
		string coinText2 = "Blue Coins: " + playerBlue;
		GUI.Box(new Rect(Screen.width - 150, 20, 130, 40), coinText2);

		if (Spawn.numberCoins + 1 == totalCount) {
			if(playerBlue > playerRed){	
				string overText = "Game Over \n Player Blue Wins! \n Player Blue: " + playerBlue + "\n Player Red: " + playerRed;
				GUI.Box (new Rect (Screen.width/2-50, Screen.height/2-25, 150, 70), overText);
			}
			if(playerBlue < playerRed){
				string overText = "Game Over \n Player Red Wins! \n Player Blue: " + playerBlue + "\n Player Red: " + playerRed;
				GUI.Box (new Rect (Screen.width/2-50, Screen.height/2-25, 150, 70), overText);

			}
			if(playerBlue == playerRed){
				string overText = "Game Over \n Tie! \n Player Blue: " + playerBlue + "\n Player Red: " + playerRed;
				GUI.Box (new Rect (Screen.width/2-50, Screen.height/2-25, 150, 70), overText);

			}

	}

}
}

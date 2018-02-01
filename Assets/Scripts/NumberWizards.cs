using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		SettingUp();
	}
	
	void SettingUp() {
		print("Before you play i need to setting up it");
		print("Please answer a  one question.");
		print("Choose a using values range: 1) 0 - 100 , 2) 0 - 500, 3) 0 - 1000.");
	}
	
	void StartGame(int inmin, int inmax) {
		max = inmax;
		min = inmin;
		guess = (int) Random.Range(min, max);
	
		
		print("========================");
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		print("The highest number you can pick is "	+ max);
		print ("The lowest number you can pick is " + min);		
		
		print ("Is the number higher or lower than " + guess + " ?");
		print ("Up arrow = higher, down = lower, return = equal");		
		
		max = max + 1;
	}
	
	void NextGuess() {
		guess = (max + min) /2;
		print ("Higher or lower than " + guess);
		print ("Up arrow = higher, down = lower, return = equal");		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("Up arrow pressed");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down arrow pressed");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!");
			SettingUp();
		} else if (Input.GetKeyDown("1")) {
			print("You change settings; Switch to using values range 1: 0 - 100");
			StartGame(0,100);
		} else if (Input.GetKeyDown("2")) {
			print("You change settings; Switch to using values range 2: 0 - 500");
			StartGame(0,500);
		} else if (Input.GetKeyDown("3")) {
			print("You change settings; Switch to using values range 3: 0 - 1000");
			StartGame(0,1000);
		}
}
}
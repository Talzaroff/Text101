using UnityEngine;
using UnityEngine.UI;	
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {rock, rock_1, rock_2, clearing, tent, death, gameover, escape};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.rock;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.rock) 		{state_rock();} 
		else if (myState == States.clearing) 	{state_clearing();} 
		else if (myState == States.rock_1) 		{state_rock_1();} 
		else if (myState == States.rock_2) 		{state_rock_2();} 
		else if (myState == States.tent) 		{state_tent();}
		else if (myState == States.death) 		{state_death();}
		else if (myState == States.gameover) 	{state_gameover();}
		else if (myState == States.escape) 		{state_escape();}
	}
	
	void state_rock () {
		text.text = "You wake up in the middle of a forest clearing, not remembering how you " +
					"got here. In the middle of the clearing, there is a distinctly shaped rock. " +
					"Trees are all around you, birds are chirping and the wind rustles " +
					"the leaves. \n" +
					"In your pocket, you find a compass. A road seems to lead North, " +
					"and two small paths each lead East and West.\n\n" +
					"Press N to head North, E to head East and W to head West.";
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.clearing;} 
		else if (Input.GetKeyDown(KeyCode.E)) 	{myState = States.rock_1;}
		else if (Input.GetKeyDown(KeyCode.W)) 	{myState = States.rock_2;}
	}
	
	void state_rock_1 () {
		text.text = "You follow the small path East. Somehow, it ends up at the same location where " +
					"you started. You notice the exact same distinctly shaped rock in the middle of the " +
					"clearing. The road North is still here, and two small paths each lead East and West.\n\n" +
					"Press N to head North, E to head East and W to head West.";
		if 		(Input.GetKeyDown(KeyCode.N)) 		{myState = States.clearing;} 
		else if (Input.GetKeyDown(KeyCode.E)) 	{myState = States.rock_1;}
		else if (Input.GetKeyDown(KeyCode.W)) 	{myState = States.rock_2;}
	}
	
	void state_rock_2 () {
		text.text = "You follow the small path West. Somehow, it ends up at the same location where " +
					"you started. You notice the exact same distinctly shaped rock in the middle of the " +
					"clearing. The road North is still here, and two small paths each lead East and West.\n\n" +
					"Press N to head North, E to head East and W to head West.";
		if 		(Input.GetKeyDown(KeyCode.N)) 		{myState = States.clearing;} 
		else if (Input.GetKeyDown(KeyCode.E)) 	{myState = States.rock_1;}
		else if (Input.GetKeyDown(KeyCode.W)) 	{myState = States.rock_2;}
	}
	
	void state_clearing () {
		text.text = "The road North leads to a clearing. In the middle, you see a circus tent, striped " +
					"red an white. It really seems the only thing you can do here is enter the circus tent. \n\n" +
					"Press C to enter the circus tent.";
		if 		(Input.GetKeyDown(KeyCode.C)) 			{myState = States.tent;}
		else if (Input.GetKeyDown(KeyCode.Escape))	{myState = States.escape;}
	}
	
	void state_tent() {
		text.text = "You died! Would you like to know how?\n\n" +
					"Press Y for Yes and N for No.";
		if (Input.GetKeyDown(KeyCode.Y)) 		{myState = States.death;}
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.gameover;}
	}
	
	void state_death() {
		text.text = "You were killed by sound.\n\n" +
					"Press N for a new game.";
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.rock;}
	}
	
	void state_gameover() {
		text.text = "Death is inevitable.\n\n" +
					"Press N for a new game.";
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.rock;}
	}
	
	
	void state_escape() {
		text.text = "You managed to escape the trap that was carefully set for you. The mind game did " +
					"not trick you into dying this time. Focusing very hard, you notice the circus tent " +
					"is an illusion. Instead, you now see a pedestal with two books on it. The first one " +
					"explains how you got here. The second one is your favorite novel.\n\n" +
					"Press N for a new game.";
		if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.rock;}
	}
}
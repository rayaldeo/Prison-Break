using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States{beginning,cell,mirror,sheets_0,lock_0,cell_mirror,sheets_1,lock_1, corridor_Zero,freedom,cafeteria
		,whistling,recreational,corridor_One,fence};
	private States myState;

	// Use this for initialization
	void Start () {
		myState=States.beginning;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState ==States.beginning){					state_Beginnging();
		}else if(myState ==States.cell){				state_cell();
		}else if(myState ==States.sheets_0){			state_sheet();
		}else if(myState ==States.sheets_1){			state_sheetOne();
		}else if(myState ==States.lock_0){				state_lockZero();
		}else if(myState ==States.lock_1){				state_lockOne();
		}else if(myState ==States.mirror){				state_mirror();	
		}else if(myState ==States.cell_mirror){			state_cellMirror();	
		}else if(myState ==States.cafeteria){			state_Cafeteria();
		}else if(myState ==States.corridor_Zero){		corridor_Zero();
		}else if(myState ==States.recreational){		state_Recreational();
		}else if(myState ==States.whistling){			state_Whistling();
		}else if(myState ==States.corridor_One){		state_CorridorOne();
		}else if(myState ==States.fence){		        state_Fence();
		}
		
	}
	
	
	void state_Beginnging(){
		text.text="You have been locked away in Prison for your horrendous crimes. "+
				"Through the years your thirst for freedom grew, finally to this breaking point. "+
				"You know that you are locked in the tightest part of the prison,D Block, and you need a"+
				" map to better navigate the prison to avoid the guards and new clothes."+
				"\n\n"+
				"Good Luck "+
		        "Press Enter Key to Begin";
		if(Input.GetKeyDown(KeyCode.Return)){ myState =States.cell;}
					
	}
	
	void state_cell(){
		text.text="In your cell,there "+
			      "are some dirty sheets on the bed, a mirror on the wall, and the door"+
				  " is locked from the outside\n\n"+
				  "Press S to View Sheets, M to view Mirror, and L to View Lock";
	
		if(Input.GetKeyDown(KeyCode.S)){ myState =States.sheets_0;}
		if(Input.GetKeyDown(KeyCode.M)){ myState =States.mirror;}
		if(Input.GetKeyDown(KeyCode.L)){ myState =States.lock_0;}
	}
	
	void state_cellMirror(){
		text.text="You are still in your cell, and you STILL want to escape! There "+
			      "are some dirty sheets on the bed, a mark where the mirror was, and that pesky door"+
				  " is still there and firmly locked"+
				  "\n\n"+
				  "Press S to View Sheets, or L to View Lock";
		
		if(Input.GetKeyDown(KeyCode.S)){ myState =States.sheets_0;}
		else if(Input.GetKeyDown(KeyCode.L)){ myState =States.lock_1;}
	}
	
	void state_sheet(){
		text.text="You can't believe you sleep in these things.Surely it's time somebody changed them."+
				  "The pleasures of prison life I guess"+
				  "\n\n"+
				  "Press R to Return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){ myState =States.cell;}
	}
	
	void state_lockZero(){
		text.text="This is one of the button locks.You have no idea what the combination is."+
				  "You wish you could somehow see where the diry fingerprints were,maybe that would help"+
				  "\n\n"+
				  "Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R)){ myState =States.cell;}
		}
		
	void state_lockOne(){
			text.text="You carefully put the mirror throught the bars, and turn it round"+
						" so you can se the lock. You can just make out fingerprints aroud"+
						" the buttons.You press the dirty buttons, and hear a click."+
					    "\n\n"+
					    "Press R to Return to roaming your cell, or press O for the Corridor";
		if(Input.GetKeyDown(KeyCode.O)){myState =States.corridor_Zero;}	
			else if(Input.GetKeyDown(KeyCode.R)){myState =States.cell_mirror;}
		}
	
	void state_sheetOne(){
		text.text="Holding a mirror in your hand doesn't make the sheets and better"+
			      "\n\n"+
				  "Press R to Return to roaming your cell";
		if(Input.GetKeyDown(KeyCode.R)){ myState =States.cell;}
	}
	
	void state_mirror(){
		text.text="The dirty old mirror on the wall seems loose"+
			      "\n\n"+
				  "Press T to Take the Mirror, or R to Return to cell";
		if(Input.GetKeyDown(KeyCode.T)){ myState =States.cell_mirror;}
		else if(Input.GetKeyDown(KeyCode.R)){ myState =States.cell;}
	}
	
	void corridor_Zero(){
		text.text="You entered into the Corridor."+
			" You are presented with two options.The cafeteria or the recreational area."+
				"\n\n"+
				"Press C for the Cafeteria or R for the Recreational Area";
		if(Input.GetKeyDown(KeyCode.C)){ myState =States.whistling;}
		if(Input.GetKeyDown(KeyCode.R)){ myState =States.recreational;}
	}
	
	void state_Whistling(){
		text.text="You start walking and you hear whistling in your direction.Is it a guard"+
				  " or another Inmate.Do you take that chance"+
			     "\n\n"+
				"Press T to Take the Chance, or W to Return to the corridor ";
		if(Input.GetKeyDown(KeyCode.T)){ myState =States.cafeteria;}
		else if(Input.GetKeyDown(KeyCode.W)){ myState =States.corridor_One;}
	}
	
	void state_Cafeteria(){
		text.text="You have entered the Cafteria, and there is a guard with a baton, ready to send you back to your cell"+
				  " You Lost!"+
				  "\n\n"+
				  "Press P to Play Again";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}	
	}
	
	void state_Recreational(){
		text.text="You have entered the outside Recreational Area, and there is a small crack in the fence."+
			"\n\n"+
				"Press A to Go throught the crack in the fence or C to return to the Corridor";
		if(Input.GetKeyDown(KeyCode.A)){ myState =States.corridor_One;}
		else if(Input.GetKeyDown(KeyCode.C)){myState=States.fence; }
	}
	
	void state_CorridorOne(){
		text.text="You entered the Corridor again."+
				  " You can hear the whistling is very close to you.You turn around and there is a guard behind you ,swinging his baton."+
				" You Lost!"+
				"\n\n"+
				"Press P to Play Again";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}	
	}
	
	void state_Fence(){
		text.text="You squeezed through the fence"+
			"You can hear the whistling  get louder and fade away into the corridor."+
			"You are unable to turn back now. You see and old storage room"+
				"\n\n"+
				"Press E";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States{beginning,cell,mirror,sheets_0,lock_0,cell_mirror,sheets_1,lock_1, corridor_Zero,freedom,cafeteria
		,whistling,recreational,corridor_One,fence,openField,woodShop,unfamiliarBuilding,shipmentTruck,caught,stayInContainter
		,leaveContainer,stayContainerFreedom};
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
		}else if(myState ==States.openField){		    state_openField();
		}else if(myState ==States.woodShop){		    state_woodShop();
		}else if(myState ==States.unfamiliarBuilding){  state_unfamiliarBuilding();
		}else if(myState ==States.caught){  			state_caught();
		}else if(myState ==States.shipmentTruck){       state_shipmentTruck();
		}else if(myState ==States.stayInContainter){    state_stayInContainter();
		}else if(myState ==States.leaveContainer){      state_leaveContainer();
		}else if(myState ==States.stayContainerFreedom){state_stayContainerFreedom();
		}
		
	}
	
	
	void state_Beginnging(){
		text.text="You have been locked away in Prison for your horrendous crimes. "+
				"Through the years your thirst for freedom grew; finally to this breaking point. "+
				"There are four block:(A,B,C,D).You know that you are locked in the tightest part of the prison,D Block. "+
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
		text.text="You can't believe you sleep in these things.Surely it's time somebody changed them. "+
				  "The pleasures of prison life I guess. "+
				  "\n\n"+
				  "Press R to Return to roaming your cell";
		
		if(Input.GetKeyDown(KeyCode.R)){ myState =States.cell;}
	}
	
	void state_lockZero(){
		text.text="This is one of the button locks.You have no idea what the combination is. "+
				  "You wish you could somehow see where the diry fingerprints were,maybe that would help. "+
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
		text.text="Holding a mirror in your hand doesn't make the sheets and better. "+
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
		if(Input.GetKeyDown(KeyCode.C)){ myState =States.corridor_One;}
		else if(Input.GetKeyDown(KeyCode.A)){myState=States.fence; }
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
		text.text="You squeezed through the fence leading to an Open Field. "+
			"You can hear the whistling  get louder and fade away into the corridor."+
			"You are unable to turn back now. You see and old storage room. "+
				"\n\n"+
				"Press O to look around the Open Field ";
		if(Input.GetKeyDown(KeyCode.O)){ myState =States.openField;}	
	}
	
	void state_openField(){
		text.text="You look around the Open Field to see your available options. "+
			     "You notcied an old wood work shop."+
				"You also see a door leading to another building that you are unfamiliar with. "+
				"\n\n"+
				"Press W to enter the Wood work shop or Press F to enter the unfamiliar building  ";
		if(Input.GetKeyDown(KeyCode.W)){ myState =States.woodShop;}	
		else if(Input.GetKeyDown(KeyCode.F)){myState=States.unfamiliarBuilding; }
	}
	
	void  state_woodShop(){
		text.text="You enter the Wood shop and immediately you see a shipping scehdule for supplies on the wall. "+
			      "You notcied that a shipment of tools will arrive in an hour. "+
				"\n\n"+
				"Press L to sneak on the next shipment ride out of the Prison or Press F to return to the Open Field.  ";
		if(Input.GetKeyDown(KeyCode.L)){ myState =States.caught;}	
		else if(Input.GetKeyDown(KeyCode.F)){myState=States.openField; }
	}
	
	void state_caught(){
		text.text="You wait for the next shipment truck to arrive and you begin to hear whistling."+
				"You hid away in the work shop hoping not to be found. "+
				"The front door of the work shop blowned open and you hear barking."+
				"The guard dogs sniffed you out. "+
				"You Lost!"+
				"\n\n"+
		"Press P to Play Again";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}
	}
	
	void state_unfamiliarBuilding(){
		text.text="You enter the Unfamiliar Builing and you noticed that there is a truck about to pull away. "+
		          "It looks like it is leaving the Prision. "+
				"\n\n"+
				"Press L to sneak on the truck and ride out of the Prison or Press F to return to the Open Field.  ";
		if(Input.GetKeyDown(KeyCode.L)){ myState =States.shipmentTruck;}	
		else if(Input.GetKeyDown(KeyCode.F)){myState=States.openField; }
	}
	
	void state_shipmentTruck(){
		text.text="You pack yourself firmly in a box that was placed in the truck. "+
			    "Just as you close the lid to the container you hear barking in the distance. "+
			    "The guards must know you are missing if they are pulling out guard dogs. "+
			    "You feel the truck beginning to slow down. "+
				"\n\n"+
				"Press S to stay in your container or press G to get out of the truck before the guard catches up.  ";
		if(Input.GetKeyDown(KeyCode.S)){ myState =States.stayInContainter;}	
		else if(Input.GetKeyDown(KeyCode.G)){myState=States.leaveContainer; }
	}
	
	 void state_stayInContainter(){
		text.text="You feel the truck come to a halt. "+
			"The back of the truck slid open,and you hear footsteps walking up to your container. "+
				"\n\n"+
				"..... "+
				"\n\n"+
				"...."+
				"BOOM!..'There was an explosion in A Block', was heard over the shreff walkies. "+
				"'We think the convict is in A Block.' "+
				"You hear the guard dash out."+
				"\n\n"+
				"Press S to stay in your container or press G to get out of the truck before the guard catches up.  ";
		if(Input.GetKeyDown(KeyCode.S)){ myState =States.stayInContainter;}	
		else if(Input.GetKeyDown(KeyCode.G)){myState=States.leaveContainer; }
	}
	
	void state_stayContainerFreedom(){
		text.text="The truck begins moving again. "+
					"The sound of guards begins to disapate as the truck begins to leave the prison. "+
					"You are Free! "+
				"\n\n"+
				"Press P to Play Again";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}
	
	}
	
	void  state_leaveContainer(){
		text.text="The truck begins moving again without you. "+
			"You see guards running in all directions, some towards to A block and some towards you. "+
				"You were caugt! "+
				"\n\n"+
				"Press P to Play Again";
		if(Input.GetKeyDown(KeyCode.P)){ myState =States.cell;}
	}
	
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicDoor : MapElement {

	override public bool isFree(){return false;}
	override public bool isPushable(){return true;}

	override public bool ProcessTurn (){
		//TODO
		return true;
	}

}

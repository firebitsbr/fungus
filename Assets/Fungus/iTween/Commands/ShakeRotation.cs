﻿using UnityEngine;
using System.Collections;

namespace Fungus
{
	[CommandInfo("iTween", 
	             "Shake Rotation", 
	             "Randomly shakes a GameObject's rotation by a diminishing amount over time.")]
	public class ShakeRotation : iTweenCommand 
	{
		public Vector3 amount;
		public Space space = Space.Self;
		
		public override void DoTween()
		{
			Hashtable tweenParams = new Hashtable();
			tweenParams.Add("name", tweenName);
			tweenParams.Add("amount", amount);
			tweenParams.Add("space", space);
			tweenParams.Add("time", duration);
			tweenParams.Add("easetype", easeType);
			tweenParams.Add("looptype", loopType);
			tweenParams.Add("oncomplete", "OnComplete");
			tweenParams.Add("oncompletetarget", gameObject);
			tweenParams.Add("oncompleteparams", this);
			iTween.ShakeRotation(target, tweenParams);
		}		
	}
	
}
﻿using System;
using System.Collections.Generic;
using UnityEngine.VR.Actions;

public interface IUsesActions
{
	/// <summary>
	/// Collection of actions that can be performed
	/// </summary>
	List<IAction> actions { set; }

	/// <summary>
	/// The delegate that performs an action
	/// </summary>
	Func<IAction, bool> performAction { set; }
}

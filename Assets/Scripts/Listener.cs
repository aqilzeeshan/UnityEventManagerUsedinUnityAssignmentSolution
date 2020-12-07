﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An event listener
/// </summary>
public class Listener : MonoBehaviour
{
	/// <summary>
	/// Use this for initialization
	/// </summary>
	public void Start()
	{
		// add listener for no argument event
        EventManager.AddNoArgumentListener(HandleMessageEvent);

        // add listener for one argument event
        EventManager.AddIntArgumentListener(HandleCountMessageEvent);
	}
	
    /// <summary>
    /// Handles the no argument event
    /// </summary>
    void HandleMessageEvent()
    {
        print("MessageEvent");
    }

    /// <summary>
    /// Handles the one argument event
    /// </summary>
    /// <param name="number">number</number>
    void HandleCountMessageEvent(int number)
    {
        print("CountMessageEvent: " + number);
    }
}

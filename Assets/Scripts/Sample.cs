//
// Sample.js
//
// Author: Nick Breslin (nickbreslin@gmail.com)
// Copyright (c) 2012
// Licensed under the MIT License
// http://opensource.org/licenses/MIT
//

using UnityEngine;
using System.Collections;

/// <summary>
/// Class description
/// </summary>

public class Sample : MonoBehaviour
{
	/// <summary>
	/// The instance.
	/// </summary>
	public static Sample instance;
	
	/// <summary>
	/// The counter.
	/// </summary>
	public int counter;
	
	/// <summary>
	/// The _value.
	/// </summary>
	private int _counter;
	
	/// <summary>
	/// Gets the counter.
	/// </summary>
	/// <returns>
	/// The counter.
	/// </returns>
	public int getCounter()
	{
		return this.counter;
	}
	
	/// <summary>
	/// Sets the counter.
	/// </summary>
	/// <param name='value'>
	/// Value.
	/// </param>
	public void setCounter(int value)
	{
		this.counter = value;
	}
}
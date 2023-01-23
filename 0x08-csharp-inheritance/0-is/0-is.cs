using System;
using System.Collections.Generic;

///<summary>Class for object</summary>
class Obj
{
	///<summary>checks is obj is an int</summary>
	///<returns>True or false</returns>
	public static bool IsOfTypeInt(object obj)
	{
		return obj is int;
	}
}

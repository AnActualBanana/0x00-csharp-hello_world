using System;
using System.Collections.Generic;

///<summary>Class for object</summary>
class Obj
{
    ///<summary>checks if obj inherits from another</summary>
	///<returns>True or false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return typeof(Array).IsInstanceOfType(obj);
    }
}

using System;

///<summary>Class for object</summary>
class Obj
{
    ///<summary>check if object is only a subclass</summary>
	///<returns>True or false</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}\
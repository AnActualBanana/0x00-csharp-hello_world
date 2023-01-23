using System;

/// <summary>Shape Class</summary>
class Shape
{
    /// <summary>Throws exception</summary>
    public virtual int Area()
    {
        throw new System.NotImplementedException("Area() is not implemented");
    }
    
}

/// <summary>Rectangle</summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    //width of rectangle
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
        if (value < 0)
        {
            throw new ArgumentException("Width must be greater than or equal to 0");
        }
        width = value;
        }
    }
    //Height of rectangle
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
        if (value < 0)
        {
            throw new ArgumentException("Height must be greater than or equal to 0");
        }
        height = value;
        }
    }

/// <summary>Area</summary>
public new int Area()
{
    return width * height;
}
public override string ToString()
{
    return string.Format("[Rectangle] {0} / {1}", width, height);
}
}

/// <summary>Square Class</summary>
class Square : Rectangle
{
    private int size;

    //size of square
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
        if (value < 0)
        {
            throw new ArgumentException("Size must be greater than or equal to 0");
        }
        Height = value;
        Width = value;
        size = value;
        }
    }
}

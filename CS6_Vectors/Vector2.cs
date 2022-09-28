namespace CS6_Vectors;

public class Vector2
{
    #region Properties

    /// <summary>
    /// x coordinate
    /// </summary>
    public double X { get; }
    
    /// <summary>
    /// y coordinate
    /// </summary>
    public double Y { get; }

    #endregion // Properties
    
    #region Computed Properties
    /// <summary>
    /// Length of the vector used in polar coordinates.
    /// </summary>
    public double R => Math.Sqrt(X * X + Y * Y);

    /// <summary>
    /// TODO:  Write this property!
    /// Calculate the angle theta that would be used in polar coordinates.
    /// </summary>
    public double Theta => throw new NotImplementedException();
    #endregion // computed properties
    
    /// <summary>
    /// Constructor:  Create an instance of a new Vector2 with the given rectangular coordinates.
    /// </summary>
    /// <param name="x">x coordinate</param>
    /// <param name="y">y coordinate</param>
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Define how the Vector2 appears when used in a string.
    /// </summary>
    /// <returns>"&lt;x, y&gt;"</returns>
    public override string ToString()
    {
        return $"<{X}, {Y}>";
    }

    
    #region Static Operators
    /// <summary>
    /// Add two vectors.
    /// Alternatively, move by a and then by b. and get the resultant total displacement.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a+b</returns>
    public static Vector2 operator +(Vector2 a, Vector2 b) => new (a.X + b.X, a.Y + b.Y);
    
    /// <summary>
    /// TODO: Write this operation!
    /// Subtract a from b.
    /// Alternatively, What displacement vector gets you from location b to location a?
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>a-b</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static Vector2 operator -(Vector2 a, Vector2 b) => throw new NotImplementedException();
    #endregion // static operators
}
using System;
namespace gPoints
{
   public class g3Points:gPoints{
    public double Z{get; private set;}
    
    public g3Points():base()
    {
        Z=0;
    }

    public g3Points(double x, double y, double z):base(x, y)
    {
        ValidateCoordinate(Z,nameof(Z));
        Z=z;
    }

    public g3Points(g3Points otherPoint):base(otherPoint)
    {
        if(otherPoint==null)
        {
            throw new ArgumentNullException(nameof(otherPoint), "Input point cannot be null.");
        }

        Z=z;
    }

    public void SetCoordinates(double x, double y, double z)
    {
        base.SetCoordinates(x, y,)
        ValidateCoordinate(Z,nameof(Z));
        Z=z;
    }

    public override double DistanceTo(gPoints otherPoin)
    {
        if(otherPoin is g3Point other3Poin)
        {
            return Math.Sqrt(
                Math.Pow(X - other3DPoint.X, 2) +
                Math.Pow(Y - other3DPoint.Y, 2) +
                Math.Pow(Z - other3DPoint.Z, 2));
            
        }
        else
        {
            return base.DistanceTo(otherPoint);
        }
    }

     public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }

   }
}
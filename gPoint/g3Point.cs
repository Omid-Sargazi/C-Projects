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

   }
}
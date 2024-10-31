using System;
namespace gPoints
{
    public double Z{get; private set;}

    public g3Point():base()
    {
        z=0;
    }

    public g3Point(double x, double y, double z):base(x, y)
    {
        ValidateCoordinate(z,nameof(Z));
        Z=z;
    }
}
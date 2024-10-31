using System;
namespace gPoint
{
    public class gPointMain
    {
        public double X{get; protected set;}
        public double Y{get; protected set;}

        public gPointMain()
        {
            X=0;Y=0;
        }

        public gPointMain(double x, double y)
        {
            ValidateCoordinate(X,nameof(x));
            ValidateCoordinate(y, nameof(y));
            X=x; Y=y;
        }

        public gPoint(gPoint otherPoint)
        {
            if(otherPoint==null)
            {
                throw new ArgumentNullException(nameof(otherPoint), "Input point cannot be null.");
            }

            X=otherPoint.X;
            Y=otherPoint.Y;
        }

        public virtual void SetCoordinates(double x, double y)
        {
            ValidateCoordinate(X, nameof(X));
            ValidateCoordinate(y), nameof(Y);
            X=x;
            Y=y;
        }

        public virtual double DistanceTo(gPoint otherPoin)
        
      {

          
            if(otherPoin==null)
            
            {       
            throw new ArgumentNullException(nameof(otherPoint), "Input point cannot be null.");

            }
            else
            {
                return Math.Sqrt(Math.Pow(X - otherPoint.X, 2) + Math.Pow(Y - otherPoint.Y, 2));
            }
        }
      

        protected void ValidateCoordinate(double value, string name)
        {
            if(double.IsNaN(value)|| double.IsInfinity(value))
            {
                throw new ArgumentException($"{name} must be a valid number.");
            }
        }

        public override string ToString()
    {
        return $"({X}, {Y})";
    }

    }
}


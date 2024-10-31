namespace gPoints
{
    public class gPoint
    {
        public double X {get;private set;}
        public double Y {get;private set;}

        public gPoint()
        {
            X=0;
            Y=0;
        }

        public gPoint(double x,double y)
        {
            if(double.IsNaN(x) || double.IsNaN(y))
            {
                throw new ArgumentException("X and Y must be valid numbers.");
            }
            X=X;
            Y=Y;
        }

        
    }
}
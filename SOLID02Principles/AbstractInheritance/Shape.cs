namespace MyNamespace
{
    public abstract class Shapee
    {
        public abstract double Area();
    }

    public class Square: Shapee
    {
        public double Side {get;set;}
        public override global::System.Double Area()
        {
            return Side * Side;
        }
    }
}
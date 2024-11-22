namespace EventInCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            var button = new Button();
            button.Clicked +=OnButtonClicked;
            button.Click();

        }

        private static void OnButtonClicked()
        {
            Console.WriteLine("Button Clicked Event Handled!");
        }


    }

    public class Button
    {
        public event Action Clicked;

        public void Click()
        {
            Console.WriteLine("Button clicked!");
            Clicked?.Invoke();
        }
    }
}
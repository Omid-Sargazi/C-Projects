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


    public class Thermostat
    {
        private int _temperature;

        public event Action<int> TemperatureChanged;

        public int Temperature
        {
            get=> _temperature;

            set{
                if(_temperature !=value)
                {
                    _temperature = value;
                    TemperatureChanged?.Invoke(_temperature);
                }
            }
        }
    }

    public class TemperatureDisplay
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged +=DisplayTemperature;
        }

        private void DisplayTemperature(int temperature)
        {
            Console.WriteLine($"Temperature changed to: {temperature}°C");
        }
    }
}
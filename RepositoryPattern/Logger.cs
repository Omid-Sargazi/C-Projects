namespace Repository
{
    public class Logger<T>
    {
        public void Log(T message)=>Console.WriteLine($"[{DateTime.Now}] {message}");
    }
}
namespace MyNamespace
{
    public interface IPlayable
    {
        void Play();
    }

    public class Gitar: IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the guitar.");
        }
    }

    public class Piano: IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing the piano.");
        }
    }
}
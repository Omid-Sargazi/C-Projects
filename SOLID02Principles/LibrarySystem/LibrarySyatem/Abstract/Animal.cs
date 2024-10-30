namespace LibrarySystem
{
    public abstract class Animal
    {
        public abstract void Speak();
        public static Animal CreateAnimal(string type)
        {
            if(type=="Dog")
            {
                return new Dog();
            }
            if(type=="Cat")
            {
                return new Cat();
            }
            throw new ArgumentException("Invalid animal type");
        }
    }
}
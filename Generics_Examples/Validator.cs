namespace Generics
{
    public class Validator<T>
    {
        public bool isValid(T item, Func<T,bool> validationLogic)=>validationLogic(item);
    }
}
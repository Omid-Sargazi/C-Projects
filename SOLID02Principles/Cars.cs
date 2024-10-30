using System;
namespace MyNamespace
{
    public class Cars
    {
        private string _model;
        public string Model{
            get =>_model;

            set{
                if(IsValidModel(value))
                {
                    _model=value;
                }
                else{
                    throw new ArgumentException("Model must be less than 15 characters and cannot contain numbers.");
                }
            }
        }
        public Cars(string model)
        {
            Model=model;
        }

        private bool IsValidModel(string model)
        {
            return !string.IsNullOrEmpty(model) && model.Length<15 && !model.Any(char.IsDigit);
        }
    }
}
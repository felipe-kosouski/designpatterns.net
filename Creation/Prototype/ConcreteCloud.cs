using System;

namespace Prototype
{
    public class ConcreteCloud : CloudMold
    {
        private string BackgroundColor;
        private string BorderColor;

        public ConcreteCloud(string backgroundColor, string borderColor)
        {
            BackgroundColor = backgroundColor;
            BorderColor = borderColor;
        }
        
        public override CloudMold Clone()
        {
            Console.WriteLine("A nuvem clonada tem contorno " + BackgroundColor + " e preenchimento " + BorderColor);
            return MemberwiseClone() as CloudMold;
        }
    }
}
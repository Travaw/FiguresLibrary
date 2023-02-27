namespace Figures.Exceptions
{
    public class SideLengthNotPositiveNumberException : Exception
    {
        public SideLengthNotPositiveNumberException() : base("В качестве длины строрны фигуры получено не положителное число") { }
    }
}

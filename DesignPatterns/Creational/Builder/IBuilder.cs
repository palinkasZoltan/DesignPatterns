namespace DesignPatterns.Creational.Builder
{
    internal interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        IBuilder BuildPartC();
    }
}

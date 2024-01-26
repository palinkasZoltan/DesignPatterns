namespace DesignPatterns.Creational.Builder
{
    internal class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public IBuilder BuildPartC()
        {
            this._product.Add("PartC1");
            return this;
        }

        public Product Build()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }

    }
}

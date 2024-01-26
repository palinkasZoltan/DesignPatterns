namespace DesignPatterns.Structural.Adapter
{
    internal class Adapter : ITarget
    {
        //Example PropertyAdapters: the UI side only sees the PropertyAdapter and not the MDD attributes
        //We can wrap in a read only 
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public int GetRequest()
        {
            int adaptedRequestResult = 0;
            string[] tempArray = adaptee.GetSpecificRequest().Split(" ");

            foreach (string temp in tempArray)
            {
                adaptedRequestResult += int.Parse(temp);
            }

            return adaptedRequestResult;
        }
    }
}

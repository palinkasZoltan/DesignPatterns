namespace DesignPatterns.Behavioral.Observer
{
    internal class BaggageInfo
    {
        public int FlightNumber { get; set; }

        public string From { get; set; }

        public int Carousel { get; set; }

        public BaggageInfo(int flightNumber, string from, int carousel)
        {
            FlightNumber= flightNumber;
            From= from;
            Carousel=carousel;
        }
    }
}

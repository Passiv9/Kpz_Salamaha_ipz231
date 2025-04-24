namespace DesignPatterns.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var runway1 = new Runway();
            var runway2 = new Runway();
            var runway3 = new Runway();

            var aircraft1 = new Aircraft("Boeing 747");
            var aircraft2 = new Aircraft("Airbus A320");
            var aircraft3 = new Aircraft("Cessna 172");

            var commandCentre = new CommandCentre(new[] { runway1, runway2, runway3 }, new[] { aircraft1, aircraft2, aircraft3 });

            aircraft1.RequestLanding(commandCentre);
            aircraft2.RequestLanding(commandCentre);
            aircraft3.RequestTakeOff(commandCentre);

            aircraft1.RequestTakeOff(commandCentre);
        }
    }
}

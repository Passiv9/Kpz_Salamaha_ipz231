namespace DesignPatterns.Mediator
{
    class Aircraft
    {
        public string Name { get; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void RequestLanding(CommandCentre commandCentre)
        {
            commandCentre.Land(this);
        }

        public void RequestTakeOff(CommandCentre commandCentre)
        {
            commandCentre.TakeOff(this);
        }
    }
}

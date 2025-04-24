using System.Collections.Generic;
using System;

namespace DesignPatterns.Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);
        }

        public void Land(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing.");
            foreach (var runway in _runways)
            {
                if (!runway.IsActive())
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing.");
                    runway.IsBusyWithAircraft = aircraft;
                    runway.HighLightRed();
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
                    return;
                }
            }
            Console.WriteLine("No free runways available for landing.");
        }

        public void TakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} is requesting takeoff.");
            foreach (var runway in _runways)
            {
                if (runway.IsBusyWithAircraft == aircraft)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                    runway.IsBusyWithAircraft = null;
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
                    return;
                }
            }
            Console.WriteLine("Aircraft is not on any runway to take off.");
        }
    }
}

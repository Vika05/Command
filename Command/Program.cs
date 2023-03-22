using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// The 'Command' interface
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class Switch
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void StoreAndExecute(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off");
        }
    }

    /// <summary>
    /// The Command for turning on the light - ConcreteCommand #1 
    /// </summary>
    public class FlipUpCommand : ICommand
    {
        private Light _light;

        public FlipUpCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }
    }

    /// <summary>
    /// The Command for turning off the light - ConcreteCommand #2 
    /// </summary>
    public class FlipDownCommand : ICommand
    {
        private Light _light;

        public FlipDownCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }
    }

    /// <summary>
    /// Command Pattern Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Commands (on/off) : ");
            string cmd = Console.ReadLine();

            Light lamp = new Light();
            ICommand switchUp = new FlipUpCommand(lamp);
            ICommand switchDown = new FlipDownCommand(lamp);

            Switch s = new Switch();

            if (cmd == "on")
            {
                s.StoreAndExecute(switchUp);
            }
            else if (cmd == "off")
            {
                s.StoreAndExecute(switchDown);
            }
            else
            {
                Console.WriteLine("Command \"on\" or \"off\" is required.");
            }

            Console.ReadKey();
        }
    }
}

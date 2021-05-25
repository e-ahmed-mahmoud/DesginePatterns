using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CompasitCommand : ICommand
    {
        private List<ICommand> _commands;

        public CompasitCommand()
        {
            _commands = new List<ICommand>();
        }

        public void Add (ICommand command)
        {
            _commands.Add(command);
        }

        public void Execut()
        {
            foreach (var command in _commands)
            {
                command.Execut();
            }
        }

    }
}

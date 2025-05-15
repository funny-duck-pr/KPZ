using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class CommandInvoker
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Invoke(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }

        public void Undo()
        {
            
        }
    }

}
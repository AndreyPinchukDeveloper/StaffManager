using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandsLibrary.Commands.Base
{
    public abstract class CommandBase : ICommand
    {
        /// <summary>
        /// This event manage add/remove subscription on events logic
        /// </summary>
        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// With this methodf we can switch our opportunity to use any command,
        /// just return false and command won't execute
        /// </summary>
        public virtual bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// The main task of this method is execute code of any command. 
        /// The main comman's logic.
        /// </summary>
        public abstract void Execute(object? parameter);

        /*
        /// <summary>
        /// We use that method to use our event when user want to enter any changes or dataabout yourself
        /// </summary>
        protected void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }*/
    }
}

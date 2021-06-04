using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// INTERFACE for the Command Pattern, implemented in each Command class
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// executes the command
        /// </summary>
        void Execute();
    }
}

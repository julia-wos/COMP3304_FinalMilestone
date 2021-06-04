using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library
    
{
    /// <summary>
    /// delegate for image loading, implemented in ImgLoader class
    /// </summary>
    /// <param name="ofdList">list of images</param>
    public delegate void LoadImg(IList<String> ofdList);

    /// <summary>
    /// delegate for command execution in the Command Pattern
    /// </summary>
    /// <param name="command">ICommand that needs executing</param>
    public delegate void ExecuteCommand(ICommand command);
}

using Nager.TextValidation.Models;
using System.Collections.Generic;

namespace Nager.TextValidation.KeyboardLayouts
{
    public interface IKeyboardLayout
    {
        IDictionary<char, Position> GetKeyPositions();
    }
}

using Nager.TextValidation.Model;
using System.Collections.Generic;

namespace Nager.TextValidation.Contract
{
    public interface IKeyboard
    {
        IDictionary<char, Position> GetCharPositions();
    }
}

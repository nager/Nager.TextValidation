using Nager.TextValidation.Models;
using System.Collections.Generic;

namespace Nager.TextValidation.KeyboardLayouts
{
    /// <summary>
    /// German Keyboard
    /// </summary>
    public class QwertzKeyboardLayout : IKeyboardLayout
    {
        public IDictionary<char, Position> GetKeyPositions()
        {
            var keyboard = new Dictionary<char, Position>
            {
                { 'a', new Position(1.3, 3) },
                { 'b', new Position(5.8, 2) },
                { 'c', new Position(3.8, 2) },
                { 'd', new Position(3.3, 3) },
                { 'e', new Position(3, 4) },
                { 'f', new Position(4.3, 3) },
                { 'g', new Position(5.3, 3) },
                { 'h', new Position(6.3, 3) },
                { 'i', new Position(8, 4) },
                { 'j', new Position(7.3, 3) },
                { 'k', new Position(8.3, 3) },
                { 'l', new Position(9.3, 3) },
                { 'm', new Position(7.8, 2) },
                { 'n', new Position(6.8, 2) },
                { 'o', new Position(9, 4) },
                { 'p', new Position(10, 4) },
                { 'q', new Position(1, 4) },
                { 'r', new Position(4, 4) },
                { 's', new Position(2.3, 3) },
                { 't', new Position(5, 4) },
                { 'u', new Position(7, 4) },
                { 'v', new Position(4.8, 2) },
                { 'w', new Position(2, 4) },
                { 'x', new Position(2.8, 2) },
                { 'y', new Position(1.8, 2) },
                { 'z', new Position(6, 4) },
                { 'ä', new Position(11.3, 3) },
                { 'ö', new Position(10.3, 3) },
                { 'ü', new Position(11, 4) },
                { ',', new Position(8.8, 2) },
                { '.', new Position(9.8, 2) },
                { '-', new Position(10.8, 2) },
                { ' ', new Position(6, 1) }
            };
            return keyboard;
        }

    }
}

using Nager.TextValidation.Contract;
using Nager.TextValidation.Model;
using System.Collections.Generic;

namespace Nager.TextValidation.KeyboardLayout
{
    public class AzertyKeyboard : IKeyboard
    {
        //French

        public IDictionary<char, Position> GetCharPositions()
        {
            var keyboard = new Dictionary<char, Position>();
            keyboard.Add('a', new Position(1, 4));
            
            keyboard.Add('b', new Position(5.8, 2));
            keyboard.Add('c', new Position(3.8, 2));
            keyboard.Add('d', new Position(3.3, 3));
            keyboard.Add('e', new Position(3, 4));
            keyboard.Add('f', new Position(4.3, 3));
            keyboard.Add('g', new Position(5.3, 3));
            keyboard.Add('h', new Position(6.3, 3));
            keyboard.Add('i', new Position(8, 4));
            keyboard.Add('j', new Position(7.3, 3));
            keyboard.Add('k', new Position(8.3, 3));
            keyboard.Add('l', new Position(9.3, 3));
            keyboard.Add('m', new Position(10.3, 3));
            keyboard.Add('n', new Position(6.8, 2));
            keyboard.Add('o', new Position(9, 4));
            keyboard.Add('p', new Position(10, 4));
            keyboard.Add('q', new Position(1.3, 3));
            keyboard.Add('r', new Position(4, 4));
            keyboard.Add('s', new Position(2.3, 3));
            keyboard.Add('t', new Position(5, 4));
            keyboard.Add('u', new Position(7, 4));
            keyboard.Add('v', new Position(4.8, 2));
            keyboard.Add('w', new Position(1.8, 2));
            keyboard.Add('x', new Position(2.8, 2));
            keyboard.Add('y', new Position(6, 4));
            keyboard.Add('z', new Position(2, 4));
            keyboard.Add('ù', new Position(11.3, 3));
            keyboard.Add(',', new Position(7.8, 2));
            keyboard.Add(';', new Position(8.8, 2));
            keyboard.Add(':', new Position(9.8, 2));
            keyboard.Add('!', new Position(10.8, 2));
            keyboard.Add(' ', new Position(6, 1));
            return keyboard;
        }

    }
}

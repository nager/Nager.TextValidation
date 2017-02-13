using Nager.TextValidation.Contract;
using Nager.TextValidation.Model;
using System.Collections.Generic;

namespace Nager.TextValidation.KeyboardLayout
{
    public class QwertyKeyboard : IKeyboard
    {
        public IDictionary<char, Position> GetCharPositions()
        {
            var keyboard = new Dictionary<char, Position>();
            keyboard.Add('a', new Position(2, 2));
            keyboard.Add('b', new Position(8.5, 1));
            keyboard.Add('c', new Position(5.5, 1));
            keyboard.Add('d', new Position(5, 2));
            keyboard.Add('e', new Position(4.5, 3));
            keyboard.Add('f', new Position(6.5, 2));
            keyboard.Add('g', new Position(8, 2));
            keyboard.Add('h', new Position(9.5, 2));
            keyboard.Add('i', new Position(12, 3));
            keyboard.Add('j', new Position(11, 2));
            keyboard.Add('k', new Position(12.5, 2));
            keyboard.Add('l', new Position(14, 2));
            keyboard.Add('m', new Position(11.5, 1));
            keyboard.Add('n', new Position(10.2, 1));
            keyboard.Add('o', new Position(13.3, 3));
            keyboard.Add('p', new Position(14.8, 3));
            keyboard.Add('q', new Position(1.5, 3));
            keyboard.Add('r', new Position(6, 3));
            keyboard.Add('s', new Position(3.5, 2));
            keyboard.Add('t', new Position(7.3, 3));
            keyboard.Add('u', new Position(10.2, 3));
            keyboard.Add('v', new Position(7.2, 1));
            keyboard.Add('w', new Position(3, 3));
            keyboard.Add('x', new Position(4.2, 1));
            keyboard.Add('z', new Position(2.3, 1));
            keyboard.Add('y', new Position(9.2, 3));
            keyboard.Add('ä', new Position(17, 2));
            keyboard.Add('ö', new Position(15.3, 2));
            keyboard.Add('ü', new Position(16.2, 3));
            keyboard.Add('.', new Position(14.9, 1));
            keyboard.Add(' ', new Position(9, 0));
            return keyboard;
        }

    }
}

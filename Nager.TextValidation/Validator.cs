using Nager.TextValidation.Contract;

namespace Nager.TextValidation
{
    public class Validator
    {
        private IKeyboard _keyboard;

        public Validator(IKeyboard keyboard)
        {
            this._keyboard = keyboard;
        }

        public double Check(string input)
        {
            var charPositions = this._keyboard.GetCharPositions();

            var distanceAverage = 0.0;
            var distance = 0.0;
            for (var i = 1; i < input.Length; i++)
            {
                input = input.ToLower();
                var c1 = input[i - 1];
                var c2 = input[i];
                if (charPositions.ContainsKey(c1) && charPositions.ContainsKey(c2))
                {
                    distance += (charPositions[c1]).Distance(charPositions[c2]);
                }
            }
            distanceAverage = (distance / input.Length);

            return distanceAverage;
        }
    }
}

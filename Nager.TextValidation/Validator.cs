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
                var lastChar = char.ToLower(input[i - 1]);
                var currentChar = char.ToLower(input[i]);

                if (char.IsUpper(input[i]) != char.IsUpper(input[i - 1]))
                {
                    distance += 1;
                }

                if (charPositions.ContainsKey(lastChar) && charPositions.ContainsKey(currentChar))
                {
                    distance += (charPositions[lastChar]).Distance(charPositions[currentChar]);
                }
            }
            distanceAverage = (distance / input.Length);

            return distanceAverage;
        }
    }
}

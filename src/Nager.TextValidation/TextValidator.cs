using Nager.TextValidation.KeyboardLayouts;

namespace Nager.TextValidation
{
    public class TextValidator
    {
        private IKeyboardLayout _keyboardLayout;

        public TextValidator(IKeyboardLayout keyboardLayout)
        {
            this._keyboardLayout = keyboardLayout;
        }

        public double Check(string input)
        {
            var keyPositions = this._keyboardLayout.GetKeyPositions();

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

                if (keyPositions.ContainsKey(lastChar) && keyPositions.ContainsKey(currentChar))
                {
                    distance += (keyPositions[lastChar]).Distance(keyPositions[currentChar]);
                }
            }

            distanceAverage = (distance / input.Length);

            return distanceAverage;
        }
    }
}

# Nager.TextValidation

With this library you can validate a text is meaningful. Its calculate a average distance from the keys of a keyboard.
Three Keyboard layouts available (Azerty, Qwerty, Qwertz)

```cs
var textValidator = new TextValidator(new QwertzKeyboardLayout());

//Good
var result = textValidator.Check("Amsterdam");
//result = 4.5072716803479853

//Bad
result = textValidator.Check("asdfghj");
//result = 0.8571428571428571
```

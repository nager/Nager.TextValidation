# Nager.TextValidation

With this library you can validate a text is meaningful. Its calculate a average distance from the keys of a keyboard.
Three Keyboard layouts available (Azerty, Qwerty, Qwertz)

```cs
var validator = new Validator(new QwertzKeyboard());

//Good
var result = validator.Check("Amsterdam");
//result = 4.5072716803479853

//Bad
result = validator.Check("asdfghj");
//result = 0.8571428571428571
```

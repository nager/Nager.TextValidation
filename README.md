# Nager.TextValidation

A lightweight .NET library to validate if text is meaningful by analyzing keyboard input patterns.  
Supports **QWERTY**, **QWERTZ**, and **AZERTY** layouts.

## Features
- 🔎 Detects random or nonsensical input  
- ⌨️ Multiple keyboard layouts supported  
- ⚡ Lightweight and easy to integrate  
- 🛠️ Simple API for quick validation  

## Example
```csharp
var textValidator = new TextValidator(new QwertzKeyboardLayout());
var keyboardDistance = textValidator.Check("Amsterdam"); //4.5072716803479853
var keyboardDistance = textValidator.Check("asdjkl"); //0.8571428571428571
````

## Use Cases

* Form validation (prevent junk input)
* Detecting spam or bot entries
* Ensuring high-quality user-generated content

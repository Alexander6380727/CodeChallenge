# CodeChallenge
## Table of Contents
* [Challenge](##-Challenge)
* [Overview](##-Overview)
* [Features](##-Features)
* [Code Structure](##-Code-Structure)
* [Testing](##-Testing)
## Challenge
Here is an old phone keypad with alphabetical letters, a backspace key, and a send button. <br>

Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter. 
For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’. <br>

You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”. <br>

Prompt:

Design and document a class of method that will turn any input to OldPhonePad into the correct output. <br>

Assume that a send “#” will always be included at the end of every input.

| Number | Letter |
| ----------- | ----------- |
| 111 | &'( |
| 222 | ABC |
| 333 | DEF |
| 444 | GHI |
| 555 | JKL |
| 666 | MNO |
| 7777 | PQRS |
| 888 | TUV |
| 9999 | WXYZ |

<br>

| Character/Digit | Action |
| ----------- | ----------- |
| 0 | Space |
| * | Backspace |
| _ | Pause |
| # | Send |

## Overview
This application converts sequences of number key presses into text, mimicking the T9-style input method used on old mobile phones. Users press number keys (1-9) multiple times to cycle through the letters associated with each key.
## Features
Following the basic requirements, here are a few features on how the program handles some cases:
* Wrap-around support: Pressing a key more times than available makes the letters wrap around. <br>
* Invalid character handling: Ignores non-digit characters (except special keys) for the output. <br>
* Unless the input ends in a '#', there is no output.
## Code Structure
### Main Components <br>
Program.cs
Contains the main application logic:
* Main: Entry point that demonstrates various test cases.
* OldPhonePad: Core method that processes the input string and converts key presses to text.
* GetCharFromKeyPress: Helper method that maps key-press combinations to specific characters. <br>

## Testing
Test Categories
1. OldPhonePad_GivenTestCases: Tests the examples provided in the original problem
2. OldPhonePad_SingleNumbers: Tests single key presses for all number keys
3. OldPhonePad_DoubleNumbers: Tests double key presses
4. OldPhonePad_TripleNumbers: Tests triple key presses
5. OldPhonePad_QuadrupleNumbers: Tests quadruple key presses (for keys 7 and 9)
6. OldPhonePad_SpecialCases: Tests edge cases and special scenarios

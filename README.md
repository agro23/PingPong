
# Leap Year

#### By Cameron Anderson & Andy Grossberg

## Description
A program to test if a given year is a leap year.

## Specifications
* Create PingPongTest object

* Create PingPong object

* choose a range

* check if the range is > 0
- Expected Input: <number> > 0
- Expected Output: None

* choose a number

* check if the number is divisible by 3
- Expected Input: 3
- Expected Output: True
- Expected Input: 4
- Expected Output: False

* check if the number is divisible by 5.
- Expected Input: 4
- Expected Output: False
- Expected Input: 5
- Expected Output: True

* check if the number is divisible by 3 and divisible by 5.
- Expected Input: 4
- Expected Output: False
- Expected Input: 3
- Expected Output: False
- Expected Input: 3
- Expected Output: False
- Expected Input: 15
- Expected Output: True

* Display a view that is a title screen.

* Make a List and display it to the screen

* Use form to ask user for a range 1-99.
- Expected Input: STRING
- Expected Output: None

* output string to main view
- Expected Input: None
- Expected Output: STRING

* validate range <=99 and > 0
- If false return to View with form

* Loop through range (converted to int32)
- Expected Input: None
- Expected Output: numbers in range to Console

* Loop through range building an output List
- Add the string of the range to a List called msg
- Expected Input: None
- Expected Output: List to the View()

* Loop through range building an output List
- test if Loop number is divisible by 3, if true change string to "ping"
- Expected Input: None
- Expected Output: List (with ping's in it also) to View()

* Loop through range building an output List
- test if Loop number is divisible by 5 if true change string to "pong"
- Expected Input: None
- Expected Output: List (with pong's in it also) to View()

* Loop through range building an output List
- test if Loop number is divisible by 3 and by 5 if true change string to "ping-pong"
- Expected Input: None
- Expected Output: List (with ping-pong's in it also) to View()

* Loop through range building an output List
- test if Loop number is divisible by 3, by 5, or by 3 and by 5. If true change strings to "ping", "pong" or "ping-pong" as in previous three specs.
- Expected Input: None
- Expected Output: List (with pings, pongs, and ping-pong's in it also) to View()

* refactor code as needed.

## Setup/Installation Requirements

* Clone the git repository from 'https://github.com/camander321/LeapYearTest.git'.
* run the command 'dotnet restore' to download the necessary packages.
* run the command 'dotnet run' to build and run the server on localhost.
* use your preferred web browser to navigate to localhost:5000


## Support and contact details

* contact the author at chamburg321@gmail.com

## Technologies Used

* C#
* Asp .NET Core MVC
* HTML
* CSS
* Javascript
* Bootstrap
* JQuery

### License

Copyright (c) 2018 Cameron Anderson & Andy Grossberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

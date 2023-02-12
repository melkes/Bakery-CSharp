# Pierre's Bakery

## By Mike Wilkes

### A C# console application for a bakery

Users are given a welcome message and a price list for bread and pastry. Bread is $5 with a discount of 3 for the price of 2, while pastry is $2 with a 4 for 3 discount. User is then asked to enter a number for loaves of bread to order, followed by a prompt to enter the number of pastries. The application then prints the total cost of the order

---

## Technologies Used

* C#
* .NET
* MSTest
* Git

## Setup/Installation Requirements

* Clone this repository
* Navigate to the Bakery directory
* In a terminal window, run:
  * `dotnet restore`
  * `dotnet run`
### To run the unit tests
* Install MSTest
* Navigate to the Bakery.Tests directory
* In the terminal window, enter:
  * `dotnet test`

## Roadmap
### Future development could include:
* Allow users to buy different kinds of Bread and Pastry.
* Add additional deals.
* Use class inheritance to DRY up code for the Bread and Pastry class.
* Allow users to keep adding to an order by using static variables.

### Project specs

- There should be two classes: one for Bread and one for Pastry.
- Bread class should calculate cost of bread a with buy 2, get 1 free deal
- Pastry class should calculate cost of bread a with buy 3, get 1 free deal
- Prompt should show welcome message and bread/pastry prices
- Capture user input for number of loaves/pastries
- Calculate total cost of order

#### Bread 
- $5/each 
- Buy 2, get 1 free

#### Pastry
- $2/each
- Buy 3, get 1 free

## License

MIT License

Copyright (c) _2023_ _Mike Wilkes_ 

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
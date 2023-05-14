# Week 7 Independent Code Review - Pierre's Bakery in C#

#### This program is a C# console app. It uses two classes, "Bread" and "Pastry". A user can specify how many loaves of bread and how many pastries they want, and the app will return the price. The Bakery offers deals based on how much bread and pastry the customer orders.

#### By Thomas McDowell

## Technologies Used

* C#
* .NET 6.0
* MSTest

## Description
A user should be able to tell how much bread and pasty is worth, be informed about special offers, and then enter an amount for bread and/or pastry. Based on how many units they order, they will be shown how much they owe, sans any "buy-two-get-one-free" type of deals (i.e. if they get two loaves of bread for $10, they get the third one free; not for $15). The user should be welcomed upon launching the app, and any non-integers or unexpected entries should be handled with an error statement. The app should restart from a certain point, instead of canceling at end of run or in event of an error.

## Setup/Installation Req's
Follow these setup instructions:  

For C# and .NET => https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net  

For dotnet-script => https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-dotnet-script  

INSTRUCTIONS:  
Clone this repo.  
Open Terminal, GitBash, or a shell of your choice, and navigate to this project's production directory called "Bakery".  
Run "dotnet run" (without quotes) in the command line and await the UI's instructions.  
There are several prompts asking you to enter a number, or the letters "y" and "n".  
Depending on which questions you answer "y" or "n" to, there are a couple of different closing messages.  


## Known Bugs  
There are some comments left in where I tried some extra ideas, like informing the user about what a good deal they got, and making a "checkpoint" where a user could repeat a step halfway through the program instead of running it all the way through to the end. Besides that, I haven't found anything particularly code-breaking. Would like to come back to this and build out the idea I had about changing the specials based on what day it is, but for now, it's just a little easter egg that will remind you what day it is.  

UPDATE: Extra ideas have been moved to a separate branch.

## License
(C) Thomas McDowell 2023 ; MIT

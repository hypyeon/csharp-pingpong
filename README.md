# Ping Pong
by [Hayeong Pyeon](https://hypyeon.github.io/WebDevWebsite/)

### Description
- This is an in-class prompt **Ping Pong** provided by Epicodus. 

### Objectives
- A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
1) All numbers divisible by 3 are replaced by "ping".
2) All numbers divisible by 5 are replaced by "pong"
3) All numbers divisible by both 3 and 5 are replaced by "ping-pong".
- If the user enters `15`, the program will return:
```
1  
2  
"ping"  
4  
"pong"  
"ping"  
7  
8  
"ping"  
"pong"  
11  
"ping"  
13  
14  
"ping-pong"  
```
- Requirements: 
1) Use TDD and the RGR workflow to develop your business logic.
2) Create your business logic before you create your UI logic.

### Setup Instructions
1. Clone this repo.
2. Open your terminal and navigate to this project's production directory called **PingPong**.
3. In the command line, run the command `dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.
4. Optionally, you can run `dotnet build` to compile this console app without running it.
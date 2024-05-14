# Dice Roll Game

## Overview
Dice Roll Game is a simple console application written in C#. In this game, players are given three attempts to guess the number on a virtual dice, ranging from 1 to 6.

## How to Play
- The player is prompted to guess a number between 1 and 6.
- If the player's guess is correct, they win immediately.
- If the guess is incorrect, the number of tries is decremented.
- The game ends either when the player guesses correctly or exhausts their three attempts.

## Requirements
- .NET SDK (Compatible with .NET Core 3.1 or later)

## Running the Game
To run the game, follow these steps:
1. Ensure that .NET SDK is installed on your system.
2. Clone this repository or download the source code.
3. Navigate to the directory containing the game's code.
4. Run the command `dotnet run` in your terminal or command prompt.

## Game Implementation Details
The game logic is encapsulated in the `DiceRollGame` class, which generates a random number between 1 and 6 (inclusive). This number represents the dice's face value. The `IsRightGuess` method checks if the player's guess matches this value.

## Contributions
Contributions are welcome. Please feel free to fork the repository, make changes, and submit a pull request.

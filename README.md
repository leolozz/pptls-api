## Rock, Paper, Scissors, Lizard, Spock game API.
Default Rock, Paper, Scissors game is a great way to take decisions based on luck, but it commonly ends in a draw match. Based on that situation, *"Rock, Paper, Scissors, Lizard, Spock"* adds two new move options, lowering the chances of a draw outcome.

This is the project of an API that receives values of two moves of the game Rock, Paper, Scissors, Lizard, Spock and returns the match results according to the game rules developed by Sam Kass.

!["Scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes scissors."](https://rpsls.rocks/assets/img/rpsls/rock-paper-scissors-lizard-spock-rules.jpg)

## Requirements

 - Microsoft Windows Operation System running .NET Core 5;
 - Visual Studio or Visual Studio Code;

## Installation

 - Open Visual Studio
 - Run terminal in BTG.PPTLS.API:
	>`dotnet publish -c Release`
	
 -  Run
	 >\BTG.PPTLS.API\bin\Release\net5.0\BTG.PPTLS.API.exe
	 
 - Rest API is listening to http://localhost:5000
## Usage
 - The endpoint receives a list of two objects via Http POST and returns one object as result;
 - Endpoint: /Game/PlayGame
 - Method: POST

	> Input example:
	 [{"id": 1, "moveId": 2 },{"id":2, "moveId":3}]
	
	>Output
	[{"id": 1, "moveId": 2 }]
	
	### Inputs description
	

	 - **id** refers to player's id. Must have the value of 1 or 2.
	 - **moveId** refers to player's move id. Must have value between 0 and 4.
		>Property moveId references:
		0: rock,
		1: paper,
		2: scissors,
		3: lizard,
		4: spock.
		
	### Outputs description
	

	 - API method will return an object containing:
		 - In case of draw,  **id = 0** and **moveId**
		 - In case of having a winner, winner's **id** and **moveId** inputed in the request

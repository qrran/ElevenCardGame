# ElevenCardGame

ElevenCardGame is a console game developed using C#. The game starts with a full deck of 52 cards. Then, NPC(Non Player Character) will distribute 9 cards to the board for player to select. Player needs to select valid combinations and submit to NPC, if the combination is valid, NPC will remove the cards that Player selected from the board and add new cards to the board.<br>

There are two valid combinations:<br>

1. Player select **2 cards** that has their rank added exactly up to **11**.
2. Player select **3 cards** with rank of "Jack", "Queen", "King" and order doesn't matter.<br>

Player wins if there's no more cards left.<br>

Player loses if there's no more valid combinations on board and still card left.

## How to Run?

`cd ElevenCardGame`<br>
`dotnet run`

## Output

```plain
Welcome to Eleven Card Game!
-----------Rule-------------
Select cards from the board
You can't select two same cards
*******************************************************
**Please type exact card name as it appeared on board**
*******************************************************

------------------------
Current cards on board:
King Diamonds
Jack Clubs
Nine Hearts
Nine Diamonds
King Spades
Queen Diamonds
Eight Clubs
Six Diamonds
Seven Spades

Pick a card:
Jack Clubs
You have selected: Jack Clubs
Card selected successfully.
Your current rank is: 11

Pick a card:
King Diamonds
You have selected: King Diamonds
Card selected successfully.
Your current rank is: 24

Pick a card:
Queen Diamonds
You have selected: Queen Diamonds
Card selected successfully.
Your current rank is: 36
Valid combination! Cards have been removed.

------------------------
Current cards on board:
Nine Hearts
Nine Diamonds
King Spades
Eight Clubs
Six Diamonds
Seven Spades
Ace Clubs
King Clubs
Five Hearts

Pick a card:
Six Diamonds
You have selected: Six Diamonds
Card selected successfully.
Your current rank is: 6

Pick a card:
Five Hearts
You have selected: Five Hearts
Card selected successfully.
Your current rank is: 11
Valid combination! Cards have been removed.

------------------------
Current cards on board:
Nine Hearts
Nine Diamonds
King Spades
Eight Clubs
Seven Spades
Ace Clubs
King Clubs
King Hearts
Ace Hearts

Pick a card:
Nine Hearts
You have selected: Nine Hearts
Card selected successfully.
Your current rank is: 9

Pick a card:
Nine Diamonds
You have selected: Nine Diamonds
Card selected successfully.
Your current rank is: 18
Invalid combination. Please select again.

------------------------
Current cards on board:
Nine Hearts
Nine Diamonds
King Spades
Eight Clubs
Seven Spades
Ace Clubs
King Clubs
King Hearts
Ace Hearts

Pick a card:
```

## To-DO

- Add more error handling to different user input cases
- Check for duplicate card selection
- Quit the game if player want to quit

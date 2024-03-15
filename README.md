# ElevenCardGame

## How to Run?

`cd ElevenCardGame`<br>
`dotnet run`

**Output**

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

- improve user input cases
- check for duplicate card selection


//Authors: Garret Hay
//Date: 09/05/2018
//File: README.txt
//Description: Readme for WelcomeItems program

//Instructions

1: Pick an option from the list
	'1' to add to the inventory list
	'2' to restock an existing object in the inventory list
	'3' to selling an amount of items of an existing object in the inventory list
	'4' to report and reevaluate the stock of items in the inventory list
	'5' to retrieve information on (n) a certain item or (y) all items in the inventory list
Choices:
1:(Add) To add an object to the inventory list
   1.1 - Choose a type of item to be added:
		1: a Book
		2: a Movie
		3: a Potion
   1.2 - Name the item being added
   1.3 - Choose the amount to be added of that object to the list
   1.4 - Enter the price amount in (D.CC)
	   -- For example: "2.34"
	   -- If the amount has more than 2 decimal places the program will automatically round to the nearest cent
   1.4 - IMPORTANT: The ID of the item for future actions is given at the last line. (also see Info)

2:(Restock) To restock an existing object in the inventory list
	2.1 - Give the ID of the object to be restock
	2.2 - Give the integer to be added to the previous stock

3:(Sell) To selling an amount of items of an existing object in the inventory list
	3.1 - Give the ID of the object being sold
	3.2 - Give the amount being sold
		--If the amount sold is larger than the amount in stock the sell will be canceled

4:(Lost) To report and reevaluate the stock of items in the inventory list
	4.1 - Give the ID of the object being lost
	4.2 - Give the amount that has been lost
		--If the amount is larger than the total stock the lost report will be canceled
	
5:(Info) To retrieve information of a certain item or all items in the inventory list
	5.1 - Enter the character 'y' or 'n' to choose whether to view all the inventory list or a certain object respectively
		5.2.1 - If 'y' the list will be displayed with a newline between each entry
		5.2.2 - If 'n' then enter the ID of the item to be viewed
	

6:(Exit)
	6.1 - Hit the 'enter' key to exit the program

//Design decisions

1: Added a Lost function to abstract & overwritten on all objects that will remove up to the entire stock of the object if 'lost'

2. Added a second option to the Info portion to print entire inventory & to give the IDs in case forgotten

3: Added the System.Globalization to all non-main classes, so the 'double' value of Prices will appear
   with both a '$' & in proper 2 decimal places when in out stream
4: Added multiple while loops for if an invalid option in choices are made
   For example, when adding adding to the list if an option not as a Book, Movie, or Potion it will loop back and ask again.
//Known errors
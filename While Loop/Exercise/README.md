## Conditions of the assignments:

## 1) Annie goes to her hometown after a very long period outside the country. On her way home, she sees her grandmother's old library and remembers her favorite book. Help Annie by writing a program in which she enters the book (text) she is looking for. Until Annie finds her favorite book or checks all the ones in the library, the program must read each time on a new line the name of each subsequent book (text). The books in the library are out of stock once you get the "No More Books" text.

### • If it does not find the requested book to be printed on two lines:

### o "The book you are looking for is not here!"

### o "You checked {number} books."

### • If he finds his book, one line is printed:

### o "You checked {number} books and found it."

## 2) Write a program in which Marin solves exam problems until she receives an "Enough" message from her lecturer. For each solved task he gets a grade. The program should stop reading data on the command "Enough" or if Marin receives the specified number of unsatisfactory marks.

### Any score less than or equal to 4 is unsatisfactory.

### Input

### • In the first row - number of unsatisfactory grades - an integer in the interval [1...5]

### • After that, two lines are repeatedly read:

### o Task name - text (string)

### o Score - an integer in the range [2…6]

### Output

### • If Marin gets to the "Enough" command, print on 3 lines:

### o "Average score: {average score}"

### o "Number of problems: {number of all problems}"

### o "Last problem: {last problem name}"

### • If he receives the specified number of failing grades:

### o "You need a break, {number of unsatisfactory grades} poor grades."

### Average grade to be formatted to the second decimal place.

## 3) Jessie has decided to raise money for a field trip and she wants you to help her find out if she will be able to raise the necessary amount. She saves or spends some of her money every day. If she wants to spend more than her available money, she will spend as much as she has and she will have BGN 0 left.

### Input

### The console reads:

### • Money needed for the excursion - a real number in the interval [1.00...25000.00]

### • Available money - a real number in the interval [0.00...25000.00]

### Then they are repeatedly read in two lines:

### • Type of action – text with "spend" and "save" options

### • Amount to save / spend - real number in the interval [0.01… 25000.00]

### Output

### The program must be terminated in the following cases:

### • If for 5 consecutive days Jesse only spends, the console should read:

### o "You can't save the money."

### o "{Total Days Elapsed}"

### • If Jesse collects the money for the vacation, the console displays:

### o "You saved the money for {total number of days passed} days."

## 4) Gabby wants to start a healthy lifestyle and has set a goal of walking 10,000 steps every day.

### Some days, however, she is very tired from work and will want to go home before she achieves her goal. 

### Write a program that reads from the console how many steps she takes each time she goes out during the day, and when she reaches her goal it says "Goal reached! Good job!" and how many more steps did "{difference between steps} steps over the goal!"

### If she wants to go home before then, she will enter the command "Going home" and enter the steps she took on her way home. After which, if she failed to reach her goal, the console should read: "{difference between steps} more steps to reach goal."

## 5) Vending machine manufacturers wanted to make their machines return as little change as possible. Write a program that takes an amount - the change to be returned and calculates the least amount of coins that can be returned.

## 6) You're invited to a 30th birthday party where the birthday boy treats himself to a huge cake. However, he does not know how many pieces the guests can take from it. Your task is to write a program that counts the number of pieces the guests have taken before it runs out. You will get the dimensions of the cake (width and length - integers in the range [1...1000]) and then on each line, until you receive the command "STOP" or until the cake runs out, the number of pieces the guests take from her.

### Note: One piece of cake is 1x1 cm in size.

### Print one of the following lines to the console:

### • "{number of pieces} pieces are left." - if you get to STOP and haven't run out of cake pieces

### • "No more cake left! You need {number of missing pieces} pieces more."

## 7) On his eighteenth birthday, Jose decided that he was going to move out and live in a boarding house. He packed his luggage in boxes and found a suitable ad for an apartment for rent. He begins to carry his luggage in parts because he cannot carry it all at once. He has limited free space in his new home where he can arrange things so that the place is livable.

### Write a program that calculates the free volume of Jose's apartment that remains after he has moved his luggage.

### Note: One carton is exact dimensions: 1m. x 1m. x 1m.

### Input

### The user enters the following data on separate lines:

### 1. Width of free space - an integer in the interval [1...1000]

### 2. Length of free space - an integer in the interval [1...1000]

### 3. Height of free space - an integer in the interval [1...1000]

### 4. On the next lines (until the "Done" command is received) - number of boxes that are transferred to the accommodation - an integer in the interval [1...10000]

### The program should stop reading data on a "Done" command or if free space runs out.

### Output

### Print one of the following lines to the console:

### • If you get to the "Done" command and there is still free space:

### "{number of free cubic meters} Cubic meters left."

### • If free space runs out before a "Done" command is received:

### "No more free space! You need {number of missing cubic meters} Cubic meters more."

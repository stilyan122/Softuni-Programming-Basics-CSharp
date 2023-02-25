## Conditions of the assignments:

## 1) Write a program that prints the hours of the day from 0:00 to 23:59, each on a separate line. Hours must be written in the format "{hour}:{minutes}".

## 2) Print to the console the multiplication table for the numbers 1 to 10 in the format:
### "{first multiplier} * {second multiplier} = {result}".

## 3) Write a program that calculates how many natural number solutions (including zero) the equation has:
### x1 + x2 + x3 = n
### The number n is an integer and is entered from the console.

## 4) Write a program that checks all possible combinations of a pair of numbers in the interval of two given numbers. The output is printed which order is the combination whose sum of the numbers is equal to a given magic number. If there is no combination matching the condition, a message is printed that it was not found.

### Input

### The input is read from the console and consists of three lines:

### • First row - start of interval - integer in the interval [1...999]

### • Second row - end of range - integer in range [greater than first number...1000]

### • Third line – the magic number – an integer in the interval [1...10000]

### Output

### One line should be printed to the console, according to the result:

### • If a combination is found whose sum of numbers is equal to the magic number

### o "Combination N:{sequence number} ({first number} + {second number} = {magic number})"

### • If no combination matching the condition is found

### o "{the number of all combinations} combinations - neither equals {the magic number}"

## 5) Annie loves to travel and wants to visit several different destinations this year. After choosing a destination, she will estimate how much money she will need to get there and start saving. When she has saved enough, she will be able to travel.

### From the console, the destination and the minimum budget that will be needed for the trip will be read first each time.

### Then a few sums will be read that Annie saves by working, and when she has saved enough for the trip, she will leave, and the console should read:

### "Going to {destination}!"

### When she has visited all the destinations she wants, she will enter "End" instead of a destination and the program will end.

## 6) Write a program that displays the room numbers in a building (in descending order) on the console if the following conditions are met:

### • There are only offices on each even-numbered floor

### • There are only apartments on each odd-numbered floor

### • Each apartment is designated as follows: A{floor number}{apartment number}, apartment numbers start from 0.

### • Each office is designated as follows: O{floor number}{office number}, office numbers also start from 0.

### • There are always apartments on the top floor and they are larger than the others, that's why they have an 'L' in front of the number instead of an 'A'. If there is only one floor, then there are only large apartments!

### Two integers are read from the console - the number of floors and the number of rooms per floor.

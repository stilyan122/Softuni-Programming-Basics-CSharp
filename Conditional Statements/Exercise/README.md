## Conditions of the assignments:

## 1) Three sports competitors finish in some number of seconds (between 1 and 50). Write a program that reads the times of the competitors in seconds entered by the user and calculates their total time in "minutes:seconds" format. Display seconds with a leading zero (2 => "02", 7 => "07", 35 => "35").

## 2) An integer is given - starting number of points. Bonus points are accrued on it according to the rules described below. Write a program that calculates the bonus points that the number receives and the total number of points (the number + the bonus).

• If the number is up to and including 100, the bonus points are 5.

• If the number is greater than 100, the bonus points are 20% of the number.

• If the number is greater than 1000, the bonus points are 10% of the number.

• Additional bonus points (charged separately from the previous ones):

o For an even number => + 1 pt.

o For a number that ends in 5 => + 2 pts.

## 3) Write a program that reads the hour and minutes of a 24-hour day entered by the user and calculates what the time will be in 15 minutes. Print the result in hours:minutes format. Hours are always between 0 and 23 and minutes are always between 0 and 59. Hours are written as one or two digits. Minutes are always written as two digits, with a leading zero when necessary.

## 4) Petya has a children's toy shop. She gets a big order to fulfill. With the money he will earn, he wants to go on an excursion.

Toy prices:

• Puzzle - BGN 2.60.

• Talking doll - BGN 3

• Teddy bear - BGN 4.10.

• Mignon - BGN 8.20.

• Truck - BGN 2

If the ordered toys are 50 or more, the store makes a discount of 25% of the total price. From the money earned, Petya must give 10% for the rent of the shop. Calculate whether the money will be enough for her to go on an excursion.

Input

6 lines are read from the console:

1. Excursion price - real number in the interval [1.00 … 10000.00]

2. Number of puzzles - an integer in the range [0… 1000]

3. Number of talking dolls - an integer in the interval [0 … 1000]

4. Number of teddy bears - an integer in the interval [0 … 1000]

5. Number of minions - an integer in the interval [0 … 1000]

6. Number of trucks - an integer in the interval [0 … 1000]

Output

The console prints:

• If the money is sufficient, the following is printed:

o "Yes! {remaining money} lv left."

• If the money is NOT enough, the following is printed:

o "Not enough money! lv needed."

The result must be formatted to the second decimal place.

## 5) Filming for the highly anticipated Godzilla vs. Kong movie begins. Screenwriter Adam Wingard asks you to write a program to calculate whether the budgeted funds are sufficient to make the film. The shoot will require a certain number of extras, clothing for each extra, and decor.

It is known that:

• The set for the film is worth 10% of the budget.

• For more than 150 extras, there is a 10% clothing discount.

Input

3 lines are read from the console:

Line 1. Budget for the film - a real number in the interval [1.00 … 1000000.00]

Line 2. Number of extras – an integer in the interval [1 … 500]

Line 3. Price for clothing of one extra - real number in the interval [1.00 … 1000.00]

Output

Two lines should be printed to the console:

• If the money for the decor and clothes is more than the budget:

o "Not enough money!"

o "Wingard needs {the money short for the film} leva more."

• If the money for the decor and clothes is less than or equal to the budget:

o "Action!"

o "Wingard starts filming with {remaining money} leva left."

The result must be formatted to the second decimal place.

## 6) Ivan decides to improve the World Record in long distance swimming. Enter the record in seconds that Ivan needs to beat, the distance in meters that he needs to swim, and the time in seconds that he needs to swim 1 m on the console. Write a program that calculates whether he has completed the task by it is meant that: water resistance slows it down every 15 m by 12.5 seconds. When calculating how many times Ivancho will slow down due to water resistance, the result must be rounded down to the nearest whole number.

To calculate the time in seconds for which Ivancho will swim the distance and the difference to the World Record.

Input

3 lines are read from the console:

1. The record in seconds – a real number in the interval [0.00 … 100000.00]

2. The distance in meters – a real number in the interval [0.00 … 100000.00]

3. The time in seconds for which he swims a distance of 1 m - a real number in the interval [0.00 … 1000.00]

Output

Printing to the console depends on the result:

• If Ivan has improved the World Record (his time is less than the record) we print:

o "Yes, he succeeded! The new world record is {Ivan's time} seconds."

• If he did NOT beat the record (his time is greater than or equal to the record) we print:

o "No, he failed! He was {missing seconds} seconds slower."

The result must be formatted to the second decimal place.

## 7) Peter wants to buy N video cards, M processors and P number of RAM. If the number of video cards is greater than the number of processors, you get a 15% discount on the final bill. The following prices apply:

• Video card – BGN 250/pc.

• Processor – 35% of the price of purchased video cards/pcs.

• RAM memory – 10% of the price of purchased video cards/pcs.

Calculate the amount needed to purchase the materials and to calculate whether the budget will be enough.

Input

The input consists of four lines:

1. Peter's budget - a real number in the interval [0.0…100000.0]

2. The number of video cards - an integer in the interval [0…100]

3. The number of processors - an integer in the interval [0…100]

4. The number of RAM memory - an integer in the interval [0…100]

Output

1 line is printed to the console, which should look like this:

• If the budget is sufficient:

"You have {remaining budget} leva left!"

• If the amount exceeds the budget:

"Not enough money! You need leva more!"

Format the result to the second decimal place.

## 8) During your lunch break, you want to watch an episode of your favorite series. Your task is to write a program that will tell if you have enough time to watch the episode. During the break, you have time for lunch and time for relaxation. Lunch time will be 1/8 of break time and recess time will be 1/4 of break time.

Input

3 lines are read from the console:

1. Name of series - text

2. Episode duration - an integer in the range [10… 90]

3. Rest duration - an integer in the range [10… 120]

Output

Write one line to the console:

• If there is enough time to watch the episode:

"You have enough time to watch {series name} and left with {remaining time} minutes free time."

• If you don't have enough time:

"You don't have enough time to watch {series name}, you need {necessary time} more minutes."

Time to be rounded up to the nearest whole number.

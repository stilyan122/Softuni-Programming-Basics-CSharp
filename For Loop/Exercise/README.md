## Conditions of the assignments:

## 1) Write a program that prints the numbers in the range 1 to 1000 that end in 7.

## 2) Write a program that reads n-th number of integers entered by the user and checks if there is a number among them that is equal to the sum of all the others.

• If there is such an element, print "Yes" and on a new line "Sum = " + its value

• If there is no such element, print "No" and on a new line "Diff = " + the difference between the largest element and the sum of the others (by absolute value)

## 3) Given n integers in the interval [1…1000]. Of these, some percentage p1 are below 200, another percentage p2 are from 200 to 399, another percentage p3 are from 400 to 599, another percentage p4 are from 600 to 799 and the remaining p5 percentage are from 800 and above. Write a program that calculates and prints the percentages p1, p2, p3, p4 and p5.
Example: we have n = 20 numbers: 53, 7, 56, 180, 450, 920, 12, 7, 150, 250, 680, 2, 600, 200, 800, 799, 199, 46, 128, 65. We get the following distribution and visualization:

![image](https://user-images.githubusercontent.com/117260079/221344553-550cd69b-d963-4d40-ab49-9cf3202581d9.png)

Input

The first line of the input contains the integer n (1 ≤ n ≤ 1000) - number of numbers. On the next n lines there is one whole number in the interval [1...1000] - the numbers on which the histogram should be calculated.

Output

Print the histogram to the console - 5 lines, each containing a number between 0% and 100%, to two decimal places, eg 25.00%, 66.67%, 57.14%.

## 4) Lily is now N years old. For every birthday she gets a present.

• For odd birthdays (1, 3, 5...n) she gets toys.

• For even birthdays (2, 4, 6...n) she receives money.

For the second birthday, she receives BGN 10.00, and the amount increases by BGN 10.00 for each subsequent even birthday (2 -> 10, 4 -> 20, 6 -> 30...etc.). Over the years, Lily has secretly saved the money. Lily's brother, in the years that she receives money, takes BGN 1.00 from them. Lily sold the toys received over the years, each for P leva and added the amount to the money saved. She wanted to use the money to buy a washing machine for BGN X. Write a program to calculate how much money she has collected and whether she has enough to buy a washing machine.

Input

The program reads 3 numbers entered by the user on separate lines:

• Lily's age - an integer in the range [1...77]

• The price of the washing machine - a number in the interval [1.00...10 000.00]

• Unit price of a toy - an integer in the interval [0...40]

Output

Print one line to the console:

• If Lily's money is enough:

o "Yes! {N}" - where N is the remaining money after the purchase

• If the money is not enough:

o "No! {M}" - where M is the amount missing

The numbers N and M must be formatted to the second decimal place.

## 5) A company boss notices that more and more employees are spending time on distracting websites.

To prevent this, it implements surprise checks on its employees' open browser tabs.

According to the open site in taba, the following fines are imposed:

• "Facebook" -> BGN 150

• "Instagram" -> BGN 100

• "Reddit" -> BGN 50

Input

Two lines are read from the console:

• Number of open tabs in the browser n - an integer in the interval [1...10]

• Salary - number in the interval [500...1500]

Then n - number of times website name - text is read

Output

• If during the check the salary becomes less than or equal to BGN 0, the console displays

"You have lost your salary." and the program ends.

• Otherwise, after checking the console, the balance of the salary is printed (to be printed as an integer).

## 6) You are invited by the academy to write software to calculate the points for an actor/actress. The academy will give you initial points for the actor. Each rater will then give their rating. The points the actor receives are formed by: the length of the evaluator's name multiplied by the points he gives divided by two.

If the score at any point exceeds 1250.5 the program should abort and print that the given actor has received a nomination.

Input

• Actor name - text

• Academy Points - a real number in the interval [2.0... 450.5]

• Number of evaluators n - an integer in the interval [1… 20]

On the next n-th number of lines:

o Evaluator name - text

o Points from the evaluator - a real number in the interval [1.0... 50.0]

Output

To print one line to the console:

• If points are above 1250.5:

"Congratulations, {actor's name} got a nominee for leading role with {points}!"

• If the points are not enough:

"Sorry, {actor name} you need {points needed} more!"

The result should be formatted to the first digit after the decimal point!

## 7) Climbers from all over Bulgaria gather in groups and mark the next peaks to climb. Depending on the size of the group, climbers will climb different peaks.

• Group up to 5 people - climb Musala

• Group of 6 to 12 people - climb Mont Blanc

• Group of 13 to 25 people - climb Kilimanjaro

• Group of 26 to 40 people - climb K2

• Group of 41 or more people - climb Everest

Write a program that calculates the percentage of climbers who climb each peak.

Input

A series of numbers are read from the console, each on a separate line:

• On the first line - the number of groups of climbers - an integer in the interval [1...1000]

• For each group on a separate line - the number of people in the group - an integer in the interval [1...1000]

Output

Print to the console 5 lines, each containing a percentage between 0.00% and 100.00% to the second decimal place.

• First row - the percentage of Musala climbers

• Second row – the percentage of Mont Blanc climbers

• Third row – the percentage of Kilimanjaro climbers

• Fourth row – the percentage of K2 climbers

• Fifth row – the percentage of Everest climbers

## 8) Grigor Dimitrov is a tennis player whose next goal is to climb the world rankings in men's tennis.

During the year, Grigor participated in a certain number of tournaments, and for each tournament he received points that depend on the position in which he finished in the tournament. There are three options for completing a tournament:

=> W - if winner gets 2000 points

=> F - if he is a finalist he gets 1200 points

=> SF - if semi-finalist gets 720 points

Write a program that calculates how many points Grigor will have after playing all the tournaments, knowing how many points he started the season with. Also calculate how many points he averaged from all the tournaments played and what percentage of the tournaments he won.

Input

Two lines are first read from the console:
• Number of tournaments in which he participated - an integer in the interval [1…20]

• Initial number of points in the ranking list - an integer in the interval [1...4000]

A separate line is read for each tournament:

• Tournament Stage Reached - Text - "W", "F" or "SF"

Output

Three lines are printed in the following format:

• "Final points: {number of points after the tournaments played}"

• "Average points: {average points won per tournament}"

• "{tournament won percentage}%"

Average points should be rounded down to the nearest whole number, and percentages should be formatted to the second digit after the decimal point.

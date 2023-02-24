## Conditions of the assignments:

## 1) In a movie theater, the chairs are arranged in a rectangular shape in r rows and c columns. There are three types of screenings with tickets at different prices:

• Premiere – premiere screening, at a price of BGN 12.00.

• Normal – standard projection, at a price of BGN 7.50.

• Discount – screening for children, schoolchildren and students at a reduced price of BGN 5.00.

Write a program that reads the type of projection (string), number of rows and number of columns in the hall (integers) entered by the user and calculates the total ticket revenue for a full house. Print the result in a format like the examples below, with 2 decimal places.

## 2) It's summer with very changeable weather and Victor needs your help. Write a program that, based on the time of day and the degrees, recommends Victor what clothes to wear. Your friend has different plans for each stage of the day, which also require a different appearance, you can see them from the table.

Exactly two lines are read from the console:

• Degrees - an integer in the interval [10…42]

• Text, time of day - with options - "Morning", "Afternoon", "Evening"

![image](https://user-images.githubusercontent.com/117260079/221258832-861c4a95-ad4c-4642-9654-b2180cf46fa5.png)

Print on the console one line: "It's {degrees} degrees, get your {clothes} and {shoes}."

## 3) Marin and Nellie buy a house not far from Sofia. Nellie loves flowers so much that she convinces you to write a program that will calculate how much it will cost them to plant a certain number of flowers and whether the available budget will be enough for them. Different flowers have different prices.

![image](https://user-images.githubusercontent.com/117260079/221259178-803bdb11-6c21-495f-9072-2cd7138f9dc6.png)

The following discounts are available:

• If Nellie buys more than 80 Roses - 10% discount on the final price

• If Nellie buys more than 90 Dahlias - 15% discount from the final price

• If Nellie buys more than 80 Tulips - 15% discount from the final price

• If Nellie buys less than 120 Narcissus - the price increases by 15%

• If Nellie Buys less than 80 Gladioli - the price increases by 20%

3 lines are read from the console:

• Flower type - text with options - "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

• Number of flowers - an integer in the range [10…1000]

• Budget - an integer in the range [50…2500]

To print to the console on one line:

• If their budget is sufficient - "Hey, you have a great garden with {number of flowers} {type of flowers} and {remaining amount} leva left."

• If their budget is NOT enough - "Not enough money, you need {necessary amount} leva more."

Amount to be formatted to the second decimal place.

## 4) Tony and friends loved to go fishing, they are so passionate about fishing that they decided to go fishing by boat. The price for renting the vessel depends on the season and the number of fishermen.

The price depends on the season:

• The price for renting the ship in the spring is BGN 3,000.

• The price for renting the ship in summer and autumn is BGN 4,200.

• The price for renting the ship in winter is BGN 2,600.

Depending on their number, the group benefits from a discount:

• If the group is up to 6 people inclusive - 10% discount.

• If the group is from 7 to 11 people inclusive - 15% discount.

• If the group is 12 or more - 25% discount.

Fishermen enjoy an additional 5% discount if they are an even number unless it is autumn - then they do not have an additional discount, which is charged after deducting the discount according to the above criteria.
Write a program to calculate whether the fishermen will collect enough money.

Input

Exactly three lines are read from the console.

• Group budget – an integer in the range [1…8000]

• Season - text: "Spring", "Summer", "Autumn", "Winter"

• Number of fishermen – an integer in the range [4…18]

Output

To print one line to the console:

• If the budget is sufficient:

"Yes! You have {the remaining money} leva left."

• If the budget IS NOT sufficient:

"Not enough money! You need {amount that does not reach} leva."

Amounts must be formatted to two decimal places.

## 5) Strange, but most people plan their vacation early. A young programmer has a certain budget and free time in a given season. Write a program that accepts the budget and the season as input, and outputs where the programmer will rest and how much he will spend.

The budget determines the destination and the season determines how much of the budget will be spent. If it's summer, he'll rest at a campsite, and in winter at a hotel. If he is in Europe, regardless of the season, he will rest in a hotel. Each campsite or hotel, according to the destination, has its own price that corresponds to a certain percentage of the budget:

• At BGN 100 or less - somewhere in Bulgaria

o Summer – 30% of the budget

o Winter – 70% of the budget

• At BGN 1,000. or less - somewhere in the Balkans

o Summer – 40% of the budget

o Winter – 80% of the budget

• For more than BGN 1,000. – somewhere in Europe

o When traveling around Europe, regardless of the season, will spend 90% of the budget.

Input

The input is read from the console and consists of two lines entered by the user:

• First line – Budget, a real number in the interval [10.00...5000.00].

• Second line – One of the two possible seasons: “summer” or “winter”

Output

Two lines should be printed on the console.

• First line – "Somewhere in [destination]" between "Bulgaria", "Balkans" and "Europe"

• Second line – “{Type of vacation} – {Amount spent}”

o Rest can be between "Camp" and "Hotel"

o The amount must be rounded to the second decimal place.

## 6) Write a program that reads two integers (N1 and N2) and an operator to perform a given mathematical operation on them. The possible operations are: Addition(+), Subtraction(-), Multiplication(*), Division(/) and Modular Division(%). Addition, subtraction and multiplication on the console should print the result and whether it is even or odd. In ordinary division - the result. In the case of modular division – the remainder. It should be noted that the divisor can be equal to 0(zero), and zero is not divisible. In this case, a special message must be printed.

Input 

3 lines entered by the user are read from the console:

• N1 – an integer in the interval [0...40 000]

• N2 – an integer in the interval [0...40 000]

• Operator – one symbol among: "+", "-", "*", "/", "%"

Output

To print one line to the console:

• If the operation is division:

o "{N1} / {N2} = {result}" – the result is formatted to the second decimal place

• If the operation is modular division:

o "{N1} % {N2} = {remainder}"

• In case of division by 0 (zero):

o "Cannot divide {N1} by zero"

## 7) Hotel offers 2 types of rooms: studio and apartment. Write a program that calculates the total stay price for a studio and an apartment. Prices depend on the month of stay:

![image](https://user-images.githubusercontent.com/117260079/221260345-4cdb4ce2-8c87-4f23-868a-8f81c12e1104.png)

The following discounts are also available:

• For studio, for more than 7 nights in May and October: 5% discount.

• For studio, for more than 14 nights in May and October: 30% discount.

• For studio, for more than 14 nights in June and September: 20% discount.

• For an apartment, for more than 14 nights, regardless of the month: 10% discount.

Input

The input is read from the console and contains exactly 2 lines entered by the user:

• On the first line is the month - May, June, July, August, September or October

• On the second line is the number of overnight stays - an integer in the interval [0 ... 200]

Output

To print to the console 2 lines:

• On the first line: "Apartment: {price for entire stay} lv."

• On the second line: "Studio: {price for the entire stay} lv."

The price for the whole stay formatted to two decimal places.

## 8) A student must go to an exam at a specific time (for example, 9:30 a.m.). He comes to the exam hall at a given arrival time (eg 9:40). The student is considered to have arrived on time if he arrived at the time of the exam or up to half an hour before. If he arrived more than 30 minutes earlier, he was late. If he came after the exam time, he is late. Write a program that reads an exam time and an arrival time and prints whether the student was on time, whether he was early or late, and by how many hours or minutes he was early or late.

Input

4 integers (one per line) entered by the user are read from the console:

• The first line contains the exam time - an integer from 0 to 23.

• The second line contains the minute of the exam - an integer from 0 to 59.

• The third line contains the arrival time - an integer from 0 to 23.

• The fourth line contains the arrival minute - an integer from 0 to 59.

Output

On the first line, print:

• “Late” if the student arrives later than the exam time.

• "On time", if the student arrives exactly at the time of the exam or up to 30 minutes earlier.

• “Early” if the student arrives more than 30 minutes before the exam time.

If the student arrives at least one minute after the exam time, print on the next line:

•"mm minutes after the start" for a delay of less than an hour.

•"hh:mm hours after the start" for a delay of 1 hour or more. Always print minutes with 2 digits, for example “1:03”.

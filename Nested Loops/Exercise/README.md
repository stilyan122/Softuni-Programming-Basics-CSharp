## Conditions of the assignments:

## 1) Write a program that reads an integer n entered by the user and prints a pyramid of numbers as in the examples:

![image](https://user-images.githubusercontent.com/117260079/221378355-177a1aa3-781b-4a01-9720-e92b9df63db2.png)

## 2) Write a program that reads from the console two six-digit integers in the range 100000 to 300000. The first number entered will always be less than the second. On the console, print on 1 line, separated by a space, all the numbers that are between the two numbers read by the console and meet the following condition:

### • the sum of the digits in even and odd positions must be equal. If there are no numbers matching the condition on the console, no result is displayed.

## 3) Write a program that reads from the console integers in the range until a "stop" command is received. To find the sum of all prime numbers entered and the sum of all non-prime numbers entered. Since, by definition in mathematics, negative numbers cannot be prime, if a negative number is given as an input, the following message "Number is negative." should be displayed. In this case, an entered number is ignored and not added to either sum, and the program continues its execution, waiting for the next number to be entered.

### On the output, print the two sums found on two lines in the following format:

### • "Sum of all prime numbers is: {prime numbers sum}"

### • "Sum of all non prime numbers is: {nonprime numbers sum}"

## 4) The "Train the trainers" course is coming to an end and the final evaluation is approaching. Your task is to help the jury that will evaluate the presentations by writing a program that calculates the average grade from the presentation of each presentation by a given student, and finally the average success of all of them.

### The number of people in the jury is read from the console of the first row n - an integer in the interval [1…20]

### After that, the name of the presentation - text - is read on a separate line

### For each presentation on a new line, read n - the number of ratings - a real number in the interval [2.00…6.00]

### After calculating the average score for a particular presentation, it is printed to the console

### "{presentation name} - {average grade}."

### After receiving a "Finish" command, the console prints "Student's final assessment is {average of all presentations}." and the program ends.

### All values must be formatted to the second decimal place.

## 5) Write a program that reads an integer N entered by the user and generates all possible "special" numbers from 1111 to 9999. For a number to be "special", it must satisfy the following condition:
### • N to be divided by each of its digits without a remainder.
### Example: for N = 16, 2418 is a special number:
### • 16 / 2 = 8 with no remainder
### • 16 / 4 = 4 with no remainder
### • 16 / 1 = 16 with no remainder
### • 16 / 8 = 2 with no remainder

### Input

### The input is read from the console and consists of a single integer in the range [1…600000]

### Output

### All "special" numbers separated by a space should be printed on the console

## 6) Your task is to write a program that calculates the percentage of tickets for each type of ticket sold: student, standard, and kid, for all screenings. You should also calculate what percentage of the hall is filled for each screening.

### Input

### The input is a sequence of integers and text:

### • On the first line until receiving the command "Finish" - name of the movie - text

### • On the second line – the free seats in the salon for each screening – an integer [1 … 100]

### • For each film, one line is read until the empty seats in the hall run out or until the "End" command is received:

### o Purchased ticket type - text ("student", "standard", "kid")

### Output

### The following lines should be printed to the console:

### • After each film is printed, what percentage of the theater is full

### "{movie name} - {percent occupancy of the theater}% full."

### • On receiving the command "Finish" to print four lines:

### o "Total tickets: {the total number of tickets purchased for all movies}"

### o "{percent of student tickets}% student tickets."

### o "{percentage of standard tickets}% standard tickets."

### o "{percentage of kids tickets}% kids tickets."

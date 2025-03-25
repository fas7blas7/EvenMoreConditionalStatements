# 🚀 C# Console Applications

Welcome to this collection of simple C# console applications! Each program solves a basic problem using conditional statements and user input. 🖥️✨

## 📌 Tasks

### 1️⃣ Number Type 🔢
**Namespace:** `_1_NumberType`

📌 **Description:**
This program takes an integer input and determines whether the number is **positive**, **negative**, or **zero**.

🌜 **Code Logic:**
- Reads an integer from the console.
- Checks if it's `0`, positive, or negative.
- Outputs the corresponding category.

✅ **Example Input & Output:**
```
5
```
```
positive
```

```
-3
```
```
negative
```

---

### 2️⃣ ATM 🏧💰
**Namespace:** `_2_ATM`

📌 **Description:**
This program simulates an ATM withdrawal process by checking balance, withdrawal amount, and limit.

🌜 **Code Logic:**
- Reads balance, withdrawal amount, and withdrawal limit.
- Checks if the withdrawal is possible based on conditions.
- Outputs success or an error message.

✅ **Example Input & Output:**
```
500
200
300
```
```
The withdraw was successful.
```

```
500
400
300
```
```
The limit was exceeded.
```

```
100
200
300
```
```
Insufficient availability.
```

---

### 3️⃣ Biggest Number Out of Five 🏆🔢
**Namespace:** `_3_BiggestNumberOutOfFive`

📌 **Description:**
This program reads five integers and determines the largest one.

🌜 **Code Logic:**
- Reads five integers.
- Iterates through them to find the biggest.
- Prints the largest number.

✅ **Example Input & Output:**
```
3
7
2
9
5
```
```
9
```

```
-10
-5
-3
-20
-1
```
```
-1
```

---

### 4️⃣ Number Operations ➕➖✖️🥺
**Namespace:** `_4_NumberOperations`

📌 **Description:**
This program performs basic arithmetic operations (`+`, `-`, `*`, `/`) on two integers.

🌜 **Code Logic:**
- Reads two integers from the console.
- Reads an arithmetic operator.
- Performs the corresponding operation and prints the result with two decimal places.

✅ **Example Input & Output:**
```
10
5
+
```
```
10 + 5 = 15.00
```

```
20
4
/
```
```
20 / 4 = 5.00
```

---

### 5️⃣ Vacation Expenses 🏝️💰
**Namespace:** `_5_VacationExpenses`

📌 **Description:**
This program calculates the total vacation expenses based on the season, accommodation type, and number of days.

🌜 **Code Logic:**
- Reads the season (`Spring`, `Summer`, `Autumn`, `Winter`).
- Reads the accommodation type (`Hotel` or `Camping`).
- Determines the price per night and discount percentage.
- Calculates and prints the final total cost.

✅ **Example Input & Output:**
```
Summer
Hotel
5
```
```
250.00
```

```
Winter
Camping
3
```
```
27.00
```

---

### 6️⃣ Product of Three Numbers ✖️🔢
**Namespace:** `_6_ProductOfThreeNumbers`

📌 **Description:**
This program determines whether the product of three integers is **positive**, **negative**, or **zero**.

🌜 **Code Logic:**
- Reads three integers.
- If any number is `0`, outputs `zero`.
- Counts the negative numbers.
- If the count is odd, outputs `negative`; otherwise, `positive`.

✅ **Example Input & Output:**
```
-2
3
-1
```
```
positive
```

```
4
-5
6
```
```
negative
```

```
0
3
-1
```
```
zero
```

---

### 7️⃣ Working Hours ⏰
**Namespace:** `_7_WorkingHours`

📌 **Description:**
This program determines if a store is open based on the given hour and day.

📜 **Code Logic:**
- Reads an integer hour and a string day.
- Checks if the store is open between 10:00 and 18:00 from Monday to Saturday.
- Outputs `open` if within hours, otherwise `closed`.

✅ **Example Input & Output:**
```
11
Monday
```
```
open
```
```
19
Saturday
```
```
closed
```

---

### 8️⃣ Fruit or Vegetable 🍏🥕
**Namespace:** `_8_FruitOrVegetable`

📌 **Description:**
This program determines whether an input string is a fruit or a vegetable.

📜 **Code Logic:**
- Reads a string from the console.
- Checks if it belongs to predefined categories of fruits or vegetables.
- Outputs `fruit`, `vegetable`, or `unknown`.

✅ **Example Input & Output:**
```
banana
```
```
fruit
```
```
carrot
```
```
vegetable
```
```
chocolate
```
```
unknown
```

---

### 9️⃣ Sum of Seconds ⏳
**Namespace:** `_9_SumOfSeconds`

📌 **Description:**
This program calculates the total time in minutes and seconds from three separate time inputs.

🌜 **Code Logic:**
- Reads three integer inputs representing time in seconds.
- Computes the total time and converts it to minutes and seconds.
- Displays the formatted time output.

✅ **Example Input & Output:**
```
35
45
44
```
```
2:04
```

---

### 🔟 Summer Outfit ☀️👕
**Namespace:** `_10_SummerOutfit`

📌 **Description:**
This program suggests an outfit based on the temperature and time of day.

🌜 **Code Logic:**
- Reads an integer temperature and a string representing time of day (`Morning`, `Afternoon`, `Evening`).
- Determines the appropriate outfit and shoes based on temperature ranges.
- Prints the clothing recommendation.

✅ **Example Input & Output:**
```
16
Morning
```
```
It's 16 degrees, get your Sweatshirt and Sneakers.
```

```
28
Afternoon
```
```
It's 28 degrees, get your Swim Suit and Barefoot.
```

---


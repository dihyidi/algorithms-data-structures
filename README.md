**Laboratory work 2 (data structures)**

One of the data structures should be implemented. Mine is *priority queue*.

You should perform the operations of inserting, returning an element without deleting, deleting (for example, returning and deleting the first element from the stack), and finding a specific element (if such an operation is supported by the data structure).

**How to run:**
1. Clone the repo. (git clone *url*)
2. Open cmd and go to the folder containing **Lab2.csproj**.
3. Run **dotnet run**.

------------------------------------------------------------

**Laboratory 3 - Discount program **

The fashion store has started a seasonal sale, and offers customers a discount on every 3rd product purchased. You have chosen the products you want to buy and want to take advantage of this offer to save as much money as possible. Of course, the amount you have to pay depends on the order in which you buy the goods. Knowing the price of each product, as well as the percentage of the discount, calculate the most advantageous amount for which you can buy all the products.

Input data

The input file discnt.in consists of two lines.
• The first line contains a list of integers from 0 to 1,000,000,000 (109) inclusive, separated by a space of the price of the individual goods you want to buy. The total number of goods from 1 to 10000.
• The second line contains a discount integer from 0 to 100 inclusive, which means the percentage of the discount for every third product.

Imprint
The source discnt.out file must contain one number, the minimum amount that must be spent to purchase all products.

---------------------------------------------------------------

**Laboratory 6 - Dreamers **

Fighting Antin and Ori came up with a game - to invent random binary numbers, and see if these numbers can be broken into pieces, each of which is the power of the number X in the decimal system.

For example, if X == 5, then the binary number 101110011 can be divided into 101, 11001 and 1, each of which is 5 to some degree (101 in decimal == 5 == 5 ^ 1, 11001 == 25 == 5 ^ 2 and 1 == 1 is 5 ^ 0).

Demonstrate that humans are smarter than beavers, and for a given binary number N, find the smallest number of pieces to break it into.

**Input data:**
The first line contains X - a sequence of zeros and ones and N.

**Output data:**
The smallest number of pieces into which we can divide the input number, or -1 if this is not possible.

**Limitation:**
0 < len (X) < 100
0 < N < 100

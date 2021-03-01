using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;


namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 1,2,3,4,4,3,2,1 };
            int n1 = 4;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 0, 1, 0, 3, 12, 0, 0, 0, 5 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 3, 2, 4 };
            int target = 6;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        ///Selef reflection: Pretty easy logic to follow as all I had to do was divide the array in 2 lists and then bring each element from 2 lists in series.
        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                int i = 0;
                List<int> X = new List<int>();
                List<int> Y = new List<int>();
                List<int> newList = new List<int>();

                ///This block will execute only if no of elements entered are even and double of n
                if (nums.Length == 2 * n)
                {
                    for (int k = 0; k < n; k++)/// Adding 1st n elements in first list
                    {
                        X.Add(nums[k]);
                    }

                    for (int l = n; l < (2 * n); l++)/// Adding from n+1 till last n elements in second list
                    {
                        Y.Add(nums[l]);
                    }

                    for (i = 0; i < n; i++)/// Creating 3rd list and adding 0th element first from list X and then from lit Y. Continuing till n
                    {


                        newList.Add(X[i]);
                        newList.Add(Y[i]);



                    }
                    newList.ToArray();// Converting to array and printing with a space between elements
                    for (i = 0; i < (2 * n); i++)
                    {
                        Console.Write(newList[i] + " ");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter" + 2 * n+ "elements"); /// If the elements are not in 2n form, prompt back to the user.
                }

            }
            catch (Exception e)
            {
                Console.Write(e.Message);

            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>


        ///Self Reflection: At first the problem seemed easy but a level of complexity was added by making us do it in place. I solved it with O(n^2)
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int zero = 0;
                int k = 0;
                int i;
                int j = 0;
                int length = ar2.Length;
                for (j = 0; j < length; j++)
                {
                    for (i = 0; i < length; i++)
                    {
                        if (ar2[i] == 0)/// If element found is 0 in the array
                        {



                            while (i < length - 1)/// iterating through the loop and swapping values till zero value found reaches towards the end of the array.
                            {
                                ar2[i] = ar2[i + 1];
                                i = i + 1;


                            }
                            ar2[length - 1] = zero;/// Sine all values to be replaced are zero so no point in storing it in temp variable.
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                for (k = 0; k < length; k++)/// Printing all the array values with a space
                {
                    Console.Write(ar2[k] + " ");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        /// Self Reflection: It was clear from the problem statement that we had to use dictionaries. Trick lied in getting the no of cool pair of each element will be n(n+1)/2 
        

        private static void CoolPairs(int[] nums)
        {
            try
            {
                int count = 0;
                Dictionary<int, int> coolpair = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)/// Getting the frequency of the elements.
                {
                    if (!coolpair.ContainsKey(nums[i]))
                    {
                        coolpair[nums[i]] = 0;
                    }
                    coolpair[nums[i]] += 1;
                }

                foreach (var key in coolpair.Keys)/// Based on the frequency the pattern was in n(n+1)/2, where n is the frequency of repeating element-1 and that solved it.
                {
                    int temp = coolpair[key] - 1;
                    count += (temp * (temp + 1)) / 2;
                }

                Console.WriteLine(count);

            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6 
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
       //self reflection: It checked, I can use the difference of target and array element. Getting that logic was the challenging part.
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                if (nums.Length > 1)
                {
                    Dictionary<int, int> map = new Dictionary<int, int>();

                    int diff = 0;
                    for (int i = 0; i < nums.Length; i++)
                    {
                        diff = target - nums[i];

                        //if the dictionary contains our key which means our difference then output its value
                        if (diff > 0 && map.TryGetValue(diff, out int index))
                        {
                            Console.WriteLine("[" + index + "],[" + i + "]");
                        }

                        //storing the element in dictionary if it does not exist already
                        if (!map.ContainsKey(nums[i]))
                        {
                            map.Add(nums[i], i);
                        }
                    }
                }
                else
                {
                    Console.Write("please enter 2 or more numbers");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }



        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>


        /// Self reflection: This one was easy compared to the other problems. 
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                
                Dictionary<int, string> myDictionary = new Dictionary<int, string>();
                if (s.Length == indices.Length)
                {

                    for (int i = 0; i < s.Length; i++)/// Creating a dictionary with int(indices) and string(character) pair
                    {
                        myDictionary.Add(indices[i], Convert.ToString(s[i]));
                    }
                    foreach (KeyValuePair<int, string> comb in myDictionary.OrderBy(key => key.Key))/// Ordering the string by key indices.
                    {
                        Console.Write(comb.Value);
                    }
                }
                else
                {
                    Console.WriteLine("Indice and string length should be same");// if Indices and string length are not the same then prompt the user.
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
       
        ///Self refection: Problem is a dictionary problem but took me while to think over it. 
        private static bool Isomorphic(string s1, string s2)
        {

            try
            {
                //basic sanity check is if the lengths are not equal they are definitely not isomorphic.
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                s1 = s1.ToLower();
                s2 = s2.ToLower();
                Dictionary<char, char> dict = new Dictionary<char, char>();
                for (int i = 0; i < s1.Length; i++)
                {
                    //checking if the dicionary already the contains the value.
                    //If the value is already present, loop until you find that value and check if the key of value is same as s2's current value
                    if (dict.ContainsValue(s2[i]))
                    {
                        foreach (KeyValuePair<char, char> pair in dict)
                        {
                            if (pair.Value == s2[i] && pair.Key != s1[i])
                            {
                                return false;
                            }
                        }
                    }
                    else
                    //enters if the dicionary does not have the value, it should also satisfy that the current key in loop is not already there
                    {
                        if (!dict.ContainsKey(s1[i]))
                        {
                            dict.Add(s1[i], s2[i]);
                        }

                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
                
        //self reflection: Toughest problem of the lot. 
        //Took time to figure out how I can store the marks as a array value in the dictionary, used group help to complete this problem.
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.Length >= 1 && items.Length <= 1000)
                {
                    int[,] ans = new int[2, 2];
                    int temp = 0;

                    //keeping student ID as key and marks as list. Adding marks to the list, as we need the 2D array.
                    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
                    for (int i = 0; i < items.Length/2; i++)
                    {
                        if (map.ContainsKey(items[i, 0]))
                        {
                            map[items[i, 0]].Add(items[i, 1]);
                        }
                        else
                        {
                            map.Add(items[i, 0], new List<int> { items[i, 1] });
                        }
                    }

                    //sorting and reversing our list of marks.Taking the top 5 values using linq, Summing it up and taking the average
                    foreach (KeyValuePair<int, List<int>> pair in map)
                    {
                        pair.Value.Sort();
                        pair.Value.Reverse();
                        ans[temp, 0] = pair.Key;
                        ans[temp, 1] = (pair.Value.Take(5).Sum() / 5);
                        temp = temp + 1;
                    }

                    Console.WriteLine("[" + ans[0, 0] + "," + ans[0, 1] + "]");
                    Console.WriteLine("[" + ans[1, 0] + "," + ans[1, 1] + "]");
                }


            }
            
            catch (Exception)
            {

                throw;
            }
        }


        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        //self reflection: Very interesting problem, and took a while researching online to find an approavh for it.
        public static int sumDigitSquare(int n)
        {
            int squareSum = 0;
            try
            {

                while (n != 0) // Till the digit is not zero
                {
                    int temp = (n % 10);// Finding units digit
                    squareSum += temp * temp;// Finding square of the digits
                    n = n / 10;// Finding digit other digits
                }
                return squareSum;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static bool HappyNumber(int n)
        {

            // A set to store numbers during 
            // repeated square sum process 
            HashSet<int> s = new HashSet<int>();
            s.Add(n);

            try
            {
                while (true)
                {
                    if (n == 1) return true;// If the summ obtained is 1, return True
                    n = sumDigitSquare(n);// If n is not 0, the square sum function is called again, till we either have value as 1 amd return true
                    if (s.Contains(n))
                        return false;// Or return false
                    s.Add(n);

                }


            }
            catch (Exception)
            {

                throw;
            }
        }



        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        //self Reflection: Straightforward logic to implement.
        private static int Stocks(int[] prices)
        {
            int highest = 0;
            int bd = prices[0];// Initializing buying on day as 1st day
            try
            {
                for (int i = 1; i < prices.Length; i++)// Iterating the prices of stock
                {
                    if (prices[i] - bd > highest)// Updating the max profit once I get the max difference in buy and sell prices
                    {
                        highest = prices[i] - bd;
                    }
                    if (prices[i] < bd)// Updating buying on day value once I get a lower value than the prior value
                    {
                        bd = prices[i];
                    }
                }
                return highest;
            }
            catch (Exception)
            {

                throw;
            }
        }



        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        //self reflection: The solution of this problem was in the hint provided, rest was just implementation
       
        static int fib(int n)
        {
            if (n <= 1)// Implementing Fibonacci series with recurssion that returns nth value of the series. 
                return n;
            return fib(n - 1) + fib(n - 2);
        }
        private static void Stairs(int steps)
        {
            try
            {
                Console.WriteLine(fib(steps + 1));

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}


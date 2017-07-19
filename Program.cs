using System;

namespace LinkedListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            SingleLinkedList linkedList;
            int input = 0;
            int lastPosition = 0;

            // Give an overview for the user
            Console.WriteLine("Print out a single linked list backwards");
            Console.WriteLine("Enter positive values to store in the list");
            Console.WriteLine("When done, enter a negative number");

            // Get an initial value for the headNode and initialize the list
            input = PromptForInt("Enter the first number in the list: ");
            linkedList = new SingleLinkedList(input);

            // Now finish the input
            do
            {
                input = PromptForInt("Enter a number: ");
                if (input >= 0)
                {
                    linkedList.AddToEnd(input);
                }
            } while (input >= 0);

            // Now show off the collection in reverse order
            Console.WriteLine("\nHere is your list in reverse order:");
            linkedList.Last(out lastPosition);
            for (int i = lastPosition-1; i >= -1; i--)
            {
                Console.Write(" <= ");
                linkedList.Print(linkedList.Find(i));
            }
            Console.WriteLine();
        }

        public static int PromptForInt(string prompt, int minValue = 0, int maxValue = 0)
        {
            /*
             * PromptForInt(string prompt, int minValue = 0, int maxValue = 0)
             * 
             * Retrieves valid integer input from a user, ensuring a correct value within a range
             * If min and maxValue are default, no range is checked.
             * Method user is required to ensure prompt is correctly formatted to look nice.
             * Prompt will always place a newline before displaying the prompt.
             */

            // Variables
            int outValue = 0;
            bool flag = true;

            // Enter an infinite loop until the user gives us something valid.
            while (flag)
            {
                // Display the prompt for the user to know what to enter.
                Console.Write("\n" + prompt);

                // Check for a valid input (i.e. it is a number!)
                if (int.TryParse(Console.ReadLine(), out outValue) == false)
                {
                    Console.WriteLine("\nThat is not a number.  Try again.");
                    continue;
                }

                // Verify that the number is within the proper range.
                // If the default values haven't been changed, skip this.
                if (!(minValue == 0 && maxValue == 0))
                {
                    if (outValue < minValue)
                    {
                        Console.WriteLine("Your number is smaller than the minimum acceptable.  Try again.");
                        continue;
                    }
                    if (outValue > maxValue)
                    {
                        Console.WriteLine("You number is greater than the maximum acceptable.  Try again.");
                        continue;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else        // Nothing else to do because the defaults are the same. Bye!
                {
                    flag = false;
                }
            }

            // Send the integer back!
            return outValue;
        }
    }
}

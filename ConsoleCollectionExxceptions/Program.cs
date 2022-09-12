namespace ConsoleCollectionExxceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IterateThroughList();
            //Console.WriteLine("Hello, World!");

            //int[] intArray = new int[10];

            //intArray[0] = 64;
            //intArray[1] = 128;
            //intArray[2] = 256;  
            //intArray[3] = 512;
            //Console.WriteLine("Hello, World!");

            //var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //// Remove odd numbers.
            //for (var index = numbers.Count - 1; index >= 0; index--)
            //{
            //    if (numbers[index] % 2 == 1)// test: (numbers[index] % 2 != 1)
            //    {
            //        // Remove the element by specifying
            //        // the zero-based index in the list.
            //        numbers.RemoveAt(index);
            //    }
            //}

            //// Iterate through the list.
            //// A lambda expression is placed in the ForEach method
            //// of the List(T) object.
            ////numbers.foreach (
            ////number => console.write(number + " ")) ;
            ////output: 0 2 4 6 8 ||!= 1 output: 1 3 5 7 9

            //// With each iteration of the loop, you're taking the last two integers
            //// in the list, summing them, and adding that value to the list.
            //// The loop repeats until you've added 20 items to the list.

            //var fibonacciNumbers = new List<int> { 1, 1 };
            //var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //fibonacciNumbers.Add(previous + previous2);

            //foreach (var item in fibonacciNumbers)
            //    Console.WriteLine(item);




            //****************************** Collections - Multidimensional Arrays ********************

            //int[] intArray1 = new int[5];
            //int[,] intArray2 = new int[5, 5];
            //int[,,] intArray3 = new int[5, 5, 5];
            //int[,,,] intArray4 = new int[5, 5, 5, 5];

            //intArray1[3] = 12;
            //intArray2[0, 3] = 57;
            //intArray3[1, 2, 5] = 68;
            //intArray4[2, 4, 1, 2] = 24;

            //***************************** Collections - Lists and Foreach loop ************************
            // Create a list of strings.

            //var girlNames = new List<string>();
            //girlNames.Add("Sara");
            //girlNames.Add("Rebecca");
            //girlNames.Add("Ava");
            //girlNames.Add("Molly");

            //// Iterate through the list.

            //foreach (string item in girlNames)
            //{
            //    Console.Write(item + " ");
            //}

            //Output: Sara Rebecca Ava Molly

            //Create a list of strings by using a
            //collection initializer.
            // var boyNames = new List<string> { "Solo", "Rob", "Adam", "Mats" };

            //// Iterate through the list.
            // foreach (var item in boyNames)
            //{
            //Console.Write(item + " ");
            //}
            //Output: Solo Rob Adam Mats

            //List<int> listInt = new List<int>{};

            //**************************** Generics ***************************************************
            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //Dictionary<TKey, TValue> keyValuePairs = new Dictionary<TKey, TValue>();
            // Add class Tkey and TValue

            //***************************** Collections - Dictionaries*********************************


            //Dictionary<string, DateTime> dict = new Dictionary<string, DateTime>();

            //dict["today"] = DateTime.Now;

            //Console.WriteLine("Today is: "+ dict["today"]);

            //**************************** Collections - List Initialization **************************

            //List<int> listInt = new List<int> { 5, 7, 8, 1, 2, 7, 1 };

            //new Dictionary<string, string> { {"Marcus", "marcus@lexicon.se" },
            //                                 {"Kent","kent@lexicon.se" },
            //                                 {"Simon","says@lexicon.se" },
            //                                };

            //**************************** Collections - foreach and for Loops **************************

            //foreach (int item in listInt)
            //{
            //    Console.WriteLine(item);
            //}
            //

            //// Create a list of strings by using a
            //// collection initializer.
            //var girlsName = new List<string> { "Sara","Rebecca", "Ava", "Molly" };

            //for (int index = 0; index < girlsName.Count; index++)
            //{
            //    Console.Write(girlsName[index] + " ");
            //}
            //// Output: Sara Rebecca Ava Molly
            //
            //// Create a list of strings by using a
            //// collection initializer.

            //var deleteGirlName = new List<string> { "Sara", "Rebecca", "Ava", "Molly" };

            //// Remove an element from the list by specifying
            //// the object.

            //deleteGirlName.Remove("Ava");

            //// Iterate through the list.
            //foreach (var item in deleteGirlName)
            //{
            //    Console.Write(item + " ");
            //}
            // Output: Sara Rebecca Molly
            //*************************************** 101 12 *******************************************
            //var names = new List<string> { "<name>", "Ava", "Joel" };
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}

            //Console.WriteLine();
            //names.Add("Maria");
            //names.Add("Billy");
            //names.Remove("Ava");
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");
            //}
            //Console.WriteLine($"My name is {names[0]}.");
            //Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            //Console.WriteLine($"The list has {names.Count} people in it");

            //var indexx = names.IndexOf("Joel");
            //if (indexx != -1)
            //    Console.WriteLine($"The name {names[indexx]} is at index {indexx}");

            //var notFound = names.IndexOf("Not Found");
            //Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");


            //names.Sort();
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Hello {name.ToUpper()}!");


            //}


            //**************************** Exceptions **************************************************



            //string value = "";

            //if (value == null)
            //{
            //    throw new CustomException("value is null");
            //}



        }// End of Main
        //private static void IterateThroughList()
        //{
        //    var theGalaxies = new List<Galaxy>
        //    //List<Galaxy> theGalaxies = new List<Galaxy>();
        //{
        //        new Galaxy() { Name = "Tadpole", MegaLightYears = 400 },
        //        new Galaxy() { Name = "Pinwheel", MegaLightYears = 25 },
        //        new Galaxy() { Name = "Milky Way", MegaLightYears = 0 },
        //        new Galaxy() { Name = "Andromeda", MegaLightYears = 3 },
        //};

        //    foreach (Galaxy theGalaxy in theGalaxies)
        //    {
        //        Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
        //    }

        ////Output:
        ////    Tadpole  400
        ////  Pinwheel  25
        ////  Milky Way  0
        ////  Andromeda  3
        //}

        //public class Galaxy
        //{
        //    public string? Name { get; set; }
        //    public int MegaLightYears { get; set; }
        //}
        //class CustomException : Exception
        //{
        //    public CustomException(string message)
        //    {

        //    }
        //}

    }// End of Preogram Class

}// End of Namespace
    

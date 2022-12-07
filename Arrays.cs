//Arrays
//Create new array 
int[] numbers = new int[15];

//Assigning values manualy
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

Console.WriteLine(numbers.Length);

//Declare an array with no array length implicit
int[] numbers2 = new int[] {1, 2, 3, 4, 5};

string[] names = new string[] { "Joe", "Paul", "Erika" };

//Using the for iteration statement to navigate the array
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);    
}
Console.ReadLine();

//---------------------------------------------------------//


string phrase = "In this friendly friendly world";

//Converting the string into an Array
char[] charArray = phrase.ToCharArray();

//Array method to reverse it
Array.Reverse(charArray);

//Using foreach to navigate the elements of the array
foreach(char word in charArray)
{
    Console.WriteLine(word);    
}
Console.ReadLine();

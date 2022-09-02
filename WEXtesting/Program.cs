// See https://aka.ms/new-console-template for more information
using WEXtesting;

Console.WriteLine("Hello, World!");

//string test1 = "abcdefg";
//string test2 = "abbcdefg";
//string input1 = "abcd10jk";
//string str = "GeeksforGeeks";
//string input2 = "hutg9mnd!nk9";

//bool response = Characters.HasUniqueChars(input2);

//if (response)
//{
//    Console.WriteLine("Contem ");
//}
//else
//{
//    Console.WriteLine("Não contem");
//}



string[] plan = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
Directions.DirReduc(plan);
using System.Collections.Generic;

List<string> shoppingList = new List<string>(); 

shoppingList.Add("Dreams");
shoppingList.Add("Miracles");
shoppingList.Add("Rainbows");
shoppingList.Add("Pony");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Dreams");
shoppingList.RemoveAt(1);

Console.WriteLine("--------------------------");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}

//Quest
Console.Write("How many students are in your class: ");
int studentCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input the names of the students: ");

string[] students = new string[studentCount];

for (int i = 0; i < studentCount; i++)
{
    students[i] = Console.ReadLine();
}

Console.WriteLine("---------------------");

Array.Sort(students);

for (int i = 0; i < studentCount; i++)
{
    Console.WriteLine(students[i]);
}

//Wait before closing
Console.ReadKey();
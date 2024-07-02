// See https://aka.ms/new-console-template for more information
using Product;
using Player;



Console.WriteLine("Enter the Bat and name:");
int id=Convert.ToInt32(Console.ReadLine());
string s=Convert.ToString(Console.ReadLine());
Bat bat = new Bat(id,s);
Console.WriteLine(bat);

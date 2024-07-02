// See https://aka.ms/new-console-template for more information
using GDlib;


Line l1 = new Line(new Point(2,2),new Point(10,20),5);

l1.draw();
Line l2 = new Line(new Point(22, 5), new Point(40, 60), 8);

Line l3= new Line(new Point(28, 27), new Point(100, 80), 7);
Line l4 = new Line(new Point(28, 20), new Point(1000, 50), 4);

Console.WriteLine(l1);
Console.WriteLine(l2);
Console.WriteLine(l3);
Console.WriteLine(l4);
 



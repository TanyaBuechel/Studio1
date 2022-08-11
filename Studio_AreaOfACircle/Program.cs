// See https://aka.ms/new-console-template for more information

//Prompt user for the radius of a circle
Console.WriteLine("Enter a radius: ");

//Calculate the area of the user's circle and print the result
string radius = Console.ReadLine();
float areaOfTheCircle = (float)(3.14 * float.Parse(radius) * float.Parse(radius));

//Print the results
Console.WriteLine("The area of a circle of radius " + radius + " is: " + areaOfTheCircle);

//Calculate the circumference
float circumference = (float)(2 * 3.14 * float.Parse(radius));
Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);

//Miles per gallon
Console.WriteLine("Enter miles per gallon: ");
string mpg = Console.ReadLine();
float gallonsOfGasUsed = (float)(float.Parse(radius) / float.Parse(mpg));
Console.WriteLine("Gallons of gas used: " + gallonsOfGasUsed);


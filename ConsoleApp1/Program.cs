
// TO find the hypostinuse of right angle triangle.
Console.WriteLine("Enter the value of side A");
double sideA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the value of side B");
double sideB = Convert.ToDouble(Console.ReadLine());

double h = Math.Sqrt(sideA * sideA + sideB * sideB);
Console.WriteLine("The hypotenuse of the triangle is " + h.ToString("F2"));

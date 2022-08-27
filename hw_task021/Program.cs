// программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// например: A(3,6,8);B(2,1,-7) -> 15,84     A(7,-5,0);B(1,-1,9) -> 11,53

Console.Write("введите координату 1й точки x: ");
int xa = int.Parse(Console.ReadLine());

Console.Write("введите координату 1й точки y: ");
int ya = int.Parse(Console.ReadLine());

Console.Write("введите координату 1й точки z: ");
int za = int.Parse(Console.ReadLine());

Console.Write("введите координату 2й точки x: ");
int xb = int.Parse(Console.ReadLine());

Console.Write("введите координату 2й точки y: ");
int yb = int.Parse(Console.ReadLine());

Console.Write("введите координату 2й точки z: ");
int zb = int.Parse(Console.ReadLine());

double x = Math.Pow((xb - xa), 2);
double y = Math.Pow((yb - ya), 2);
double z = Math.Pow((zb - za), 2);

Console.WriteLine("A(" + xa + ", " + ya + ", " + za + ");B(" + ya + ", " + yb + ", " + zb + ") -> " + Math.Sqrt(x+y+z));
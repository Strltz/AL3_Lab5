
using Lab5_1;

/*MyMatrix mat1 = new MyMatrix(6, 8, 0, 9);

mat1.Show();

Console.WriteLine();

mat1[1, 1]++;

mat1.Show();

Console.WriteLine();

//mat1.ChangeSize(5, 6, 0, 9);

Console.WriteLine();

mat1.ShowPartialy(2, 3, 6, 7);*/


string[] names = new string[] { "Vasya", "Petya", "Vanya"} ;
int[] born_year = new int[] { 2005, 2003, 2006 };

MyDictionary<string, int> dictionary =
    new MyDictionary<string, int>(names, born_year);

/*foreach (int i in born_year)
{
    Console.WriteLine(i);
}*/

MyList<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8 };
foreach (int i in ints)
{
    Console.WriteLine(i);
}






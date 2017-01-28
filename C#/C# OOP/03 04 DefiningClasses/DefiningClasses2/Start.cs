using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    class Start
    {
        static void Main()
        {
            var point1 = new Point3D(1, 2, 3);
            var point2 = new Point3D(5, 2, 7);
            
            //Problem 1. Structure
            Console.WriteLine("Problem 1. Structure:");
            Console.WriteLine(point1);
            Console.WriteLine(point2);
            Console.WriteLine();

            //Problem 2. Static read-only field
            Console.WriteLine("Problem 2. Static read-only field:");
            Console.WriteLine(Point3D.O);
            Console.WriteLine();

            //Problem 3. Static class
            Console.WriteLine(CalcDistanceIn3D.CalcDistance(point1, point2));

            //Problem 4. Path
            var newPath = new Path();
            newPath.AddPointToList(point1);
            newPath.AddPointToList(point2);
            newPath.AddPointToList(point1);
            newPath.AddPointToList(point1);

            //Problem 5. Generic class
            PathStorage.LoadFile();
            PathStorage.SaveFile(newPath);

            // Declare a list of type int
            GenericList<int> intList = new GenericList<int>(4);
            // Declare a list of type string
            GenericList<string> stringList = new GenericList<string>(7);

            intList.Add(-28);
            intList.Add(7);
            intList.Add(11);

            Console.Write("Problem 5: List count: ");
            Console.WriteLine(intList.Count);

            Console.Write("Problem 5: Element at index 1: ");
            Console.WriteLine(intList.ElementAtIndex(1));

            Console.Write("Problem 5: Remove the element at index 1: ");
            intList.Remove(1);
            Console.WriteLine(intList.ElementAtIndex(1));

            Console.Write("Problem 5: Insert element 12 at index 1: ");
            intList.InsertAt(12, 1);
            Console.WriteLine(intList.ElementAtIndex(1));

            Console.Write("Problem 5: The position of element 12 is with index: ");
            Console.WriteLine(intList.IndexOf(12));

            Console.Write("Problem 5: Printing the entire list: ");
            Console.WriteLine(intList.ToString());


            //Problem 6. Auto-grow
            for (int i = 0; i < 40; i+= 2)
            {
                intList.Add(i);
            }
            Console.WriteLine("Problem 6: Adding new elements to the list and expanding its size: ");
            Console.WriteLine(intList.ToString());

            //Problem 7. Min and Max
            Console.WriteLine("Problem 7: ");

            Console.Write("Thi minimal value in the entire list is: ");
            Console.WriteLine(intList.Min());

            Console.Write("Thi maximal value in the entire list is: ");
            Console.WriteLine(intList.Max());
            Console.WriteLine();

            //Problem 8. Matrix
            Console.WriteLine("Problem 8. Matrix:");
            Matrix <int> testMatrix = new Matrix<int>(7,9);

            testMatrix[3, 5] = 17;
            testMatrix[4, 5] = 60;
            var indexAtPoint = testMatrix[3, 5];
            Console.WriteLine(@"Value at index [3, 5] is: {0}", indexAtPoint);

            //this class is for testing
            Matrix<int> testMatrixFirst = new Matrix<int>(4, 4);
            Matrix<int> testMatrixSecond = new Matrix<int>(4, 4);

            //fill the first matrix
            for (int i = 0; i < testMatrixFirst.Rows; i++)
            {
                for (int j = 0; j < testMatrixFirst.Cols; j++)
                {
                    testMatrixFirst[i, j] = i + j + 1;
                }
            }

            //fill the second matrix
            for (int i = 0; i < testMatrixSecond.Rows; i++)
            {
                for (int j = 0; j < testMatrixSecond.Cols; j++)
                {
                    testMatrixSecond[i, j] = i * j;
                }
            }

            //Operations with matrix
            Matrix<int> addingMatrix = testMatrixFirst + testMatrixSecond;
            Matrix<int> substractMatrix = testMatrixFirst - testMatrixSecond;
            Matrix<int> multiMatrix = testMatrixFirst * testMatrixSecond;
            //Printing the result of adding:
            Console.WriteLine("The result from adding two matrix: ");
            addingMatrix.PrintMatrix();
            Console.WriteLine();

            //Printing the result of substracting:
            Console.WriteLine("The result from substracting two matrix: ");
            substractMatrix.PrintMatrix();
            Console.WriteLine();

            //Printing the result of multiplication:
            Console.WriteLine("The result from multiplication of two matrix: ");
            multiMatrix.PrintMatrix();
            Console.WriteLine();

            //Implement the true operator
            Console.WriteLine("Implement the true operator: ");
            if (testMatrixFirst)
            {
                Console.WriteLine("Does not have zero element");
            }
            else
            {
                Console.WriteLine("Has zero element");
            }
        }
    }
}

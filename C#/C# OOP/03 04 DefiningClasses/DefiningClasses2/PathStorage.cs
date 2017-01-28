using System;
using System.IO;

namespace DefiningClasses2
{
    static class PathStorage
    {
        //fields

        //method to load file
        public static Path LoadFile()
        {
            StreamReader reader = new StreamReader(@"C:\Users\grozd\Desktop\Telerik Academy\Visual Studio 2015\Projects\C# OOP\03 Defining Classes - Part 1\DefiningClasses2\input.txt");
           
            Path currentPath = new Path();

            using (reader)
            {
                string currentLine = reader.ReadLine();

                while (currentLine != null)
                {
                    string[] nubersOnCurrentLine = currentLine.Split(' ');

                    int x = int.Parse(nubersOnCurrentLine[0]);
                    int y = int.Parse(nubersOnCurrentLine[1]);
                    int z = int.Parse(nubersOnCurrentLine[2]);

                    Point3D currentPoint = new Point3D(x, y, z);

                    currentPath.AddPointToList(currentPoint);

                    currentLine = reader.ReadLine();
                }
            }

            return currentPath;
        }

        //method writing to file
        public static void SaveFile(Path currentPath)
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\grozd\Desktop\Telerik Academy\Visual Studio 2015\Projects\C# OOP\03 Defining Classes - Part 1\DefiningClasses2\output.txt");
            using (writer)
            {
                foreach (var item in currentPath.Points)
                {
                    string currentLine;
                    currentLine = item.ToString();
                    writer.WriteLine(currentLine);
                }
            }

        }

    }
}

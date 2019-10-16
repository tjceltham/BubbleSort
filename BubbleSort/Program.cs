using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] names = new string[4];
                int[] marks = new int[4];

                names[0] = "kevin";
                marks[0] = 1;
                names[1] = "Harrison";
                marks[1] = 99;
                names[2] = "Talal";
                marks[2] = 50;
                names[3] = "Arjan";
                marks[3] = 100;
                int temp;
                string tempname;
                for (int y = 0; y < 3; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {

                        if (marks[x] < marks[x + 1])
                        {
                            temp = marks[x + 1];
                            tempname = names[x + 1];

                            marks[x + 1] = marks[x];
                            names[x + 1] = names[x];

                            marks[x] = temp;


                        }
                    }

                }


            
        }
    }
}

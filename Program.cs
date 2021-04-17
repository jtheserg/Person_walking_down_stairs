using System;

namespace Person_walking_down_stairs
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(Person(i));
            }
            Console.ReadKey(true);
        }
        static string Person(int i)
        {
            string spacing = new string('\t', i);
            string person = $@"
{spacing}* O
{spacing}*/|\
{spacing}*/ \
{spacing}******";
            return person.TrimStart('\n');
        }
    }
}

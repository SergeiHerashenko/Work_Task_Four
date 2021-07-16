using System;
using System.Text;

namespace Task_Four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перший варіант(Дуже великий розмір масиву)
            string[,,,] Max = new string[34000, 100023, 30003, 220001];

            //Другий варіант(Максимальна місткість один символ, а вставляємо два символи)
            StringBuilder sb = new StringBuilder(1, 1);
            sb.Insert(0, "x", 2);
        }
    }
}

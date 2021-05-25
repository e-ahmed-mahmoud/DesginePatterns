using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Memento Pattern **********");

            var original = new Original
            {
                Content = "Ahmed",
                FontName = "Arial",
                FontSize = 18
            };
            var caretaker = new Caretaker();
            caretaker.Push(original.CreateMemento());

            original.Content = "Ali";
            original.FontName = "ابجد هوزد";
            original.FontSize = 12;
            caretaker.Push(original.CreateMemento());

            original.Content = "Mary";
            original.FontName = "CAls";
            original.FontSize = 15;
            caretaker.Push(original.CreateMemento());

            original.Restore(caretaker.Pop());
            Console.WriteLine(original.Content + "\t " + original.FontName + " \t" + original.FontSize );

            original.Restore(caretaker.Pop());
            Console.WriteLine(original.Content + " \t" + original.FontName + " \t" + original.FontSize);

            original.Restore(caretaker.Pop());
            Console.WriteLine(original.Content + " \t" + original.FontName + " \t" + original.FontSize);

            original.Restore(caretaker.Pop());
            Console.WriteLine(original.Content + "" + original.FontName + "" + original.FontSize);

        }
    }
}

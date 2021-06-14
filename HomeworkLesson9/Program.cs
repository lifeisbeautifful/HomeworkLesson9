using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson9
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте интерфейс Printable, содержащий метод void print().
Далее создайте класс Book, класс Journal (журнал) реализующий интерфейс Printable. создайте класс Magazine, реализующий интерфейс
    Printable.После создайте массив типа Printable, который будет содержать книги и журналы и в цикле пройти по массиву и вызвать метод 
    print() для каждого объекта. Создать метод printMagazines(Printable[] printable) в классе Magazine, который выводит на консоль 
    названия только журналов.Создать метод printBooks(Printable[] printable) в классе Book, который выводит на консоль названия только 
    книг.*/
    public interface IPrintable
    {
        string Name { get; set; }
        void Print();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Book1");
            Book book2 = new Book("Book2");
            Book book3 = new Book("Book3");

            Journal journal1 = new Journal("Journal1");
            Journal journal2 = new Journal("Journal2");
            Journal journal3 = new Journal("Journal3");

            IPrintable[] booksAndJournals = new IPrintable[6];
            booksAndJournals[0] = book1;
            booksAndJournals[1] = journal1;
            booksAndJournals[2] = book2;
            booksAndJournals[3] = journal2;
            booksAndJournals[4] = book3;
            booksAndJournals[5] = journal3;

            foreach (var item in booksAndJournals) { item.Print(); }
           
            Magazine magazine = new Magazine();
            magazine.printMagazine(booksAndJournals);
            book2.printBooks(booksAndJournals);

            Console.ReadLine();
        }
    }
    public class Book:IPrintable
    {
        public string Name { get; set; }
        public Book(string name) { Name = name; }
        public void Print() { Console.WriteLine("Book "+Name+" is printed"); }
        public void printBooks(IPrintable[]printable)
        {
            foreach (var item in printable)
            {
                if (item.GetType() == typeof(Book))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
    public class Journal:IPrintable
    {
        public string Name { get; set; }
        public Journal(string name) { Name = name; }
        public void Print() { Console.WriteLine("Journal "+Name+" is printed"); }
    }
    public class Magazine:IPrintable
    {
        public string Name{ get;set;}
        public void Print()
        {
            Console.WriteLine("Magazine");
        }
        public void printMagazine(IPrintable[]printable)
        {
            foreach (var item in printable)
            {
                if (item is Journal)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}

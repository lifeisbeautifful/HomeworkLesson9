using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте базовый абстрактный класс Document (документ), в котором создайте три метода void Headline (Заголовок), DocumentСontent 
    (Содержимое документ), Footer (подвал документа). Реализуйте конкретный класс, который наследуется от производного класса Document,
    в теле класса реализуйте все методы абстрактного класса. (Реализация может заключатся в простом выводе информации о том какая это 
    часть документа.)*/

    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Headline();
            text.DocumentContent();
            text.Footer();

            Console.ReadLine();
        }
    }
    abstract class Document
    {
        public abstract void Headline();
        public abstract void DocumentContent();
        public abstract void Footer();
    }
    class Text:Document
    {
        public override void Headline() => Console.WriteLine("Header");
        public override void DocumentContent() => Console.WriteLine("Content");
        public override void Footer() => Console.WriteLine("Footer");
    }
}

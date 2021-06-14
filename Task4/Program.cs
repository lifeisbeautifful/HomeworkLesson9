using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Создайте программу, в которой создайте класс AbstractHandler
    .В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). Создать производные классы XMLHandler, 
    TXTHandler, DOCHandler от базового класса AbstractHandler.Написать логику, которая будет выполнять определение документа и для 
    каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа. */
    
    class Program
    {
        static void Main(string[] args)
        {
            XMLhandler xmlDoc = new XMLhandler();
            TXTHandler txtDoc = new TXTHandler();
            DocHandler docDoc = new DocHandler();

            xmlDoc.Create();
            xmlDoc.Open();
            xmlDoc.Change();
            xmlDoc.Save();

            txtDoc.Create();
            txtDoc.Open();
            txtDoc.Change();
            txtDoc.Save();

            docDoc.Create();
            docDoc.Open();
            docDoc.Change();
            docDoc.Save();

            Console.ReadLine();
        }
    }
    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    public class XMLhandler:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Xml document is opened");
        public override void Create() => Console.WriteLine("Xml document is created");
        public override void Change() => Console.WriteLine("Edits saved to xml document");
        public override void Save() => Console.WriteLine("Xml document is saved");
    }
    public class TXTHandler:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Txt document is opened");
        public override void Create() => Console.WriteLine("Txt document is created");
        public override void Change() => Console.WriteLine("Edits saved to txt document");
        public override void Save() => Console.WriteLine("Txt document is saved");
    }
    public class DocHandler:AbstractHandler
    {
        public override void Open() => Console.WriteLine("Doc document is opened");
        public override void Create() => Console.WriteLine("Doc document is created");
        public override void Change() => Console.WriteLine("Edits saved to doc document");
        public override void Save() => Console.WriteLine("Doc document is saved");
    }
    
}

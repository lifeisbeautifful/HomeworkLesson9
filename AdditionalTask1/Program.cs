using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalTask1
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
   Создайте программу, в которой создайте класс базовый класс Employee (Сотрудник), в котором создайте свойство типа string с именем Name
    (имя сотрудника), свойство типа int с именем Age (возраст сотрудника), поле типа double с именем Salary (оклад сотрудника). После чего
    создайте два класса:  Workman (рабочий) и Director (Директор). В теле класса Workman создайте поле типа string с названием отдела. 
    В теле класса Director создайте поле типа массива сотрудников Employee[] – поле должно содержать всех подчинённых руководителя. 
    Для каждого из классов переопределите метод ToString(), таким образом, чтоб оно выводило полную, информацию о сотруднике 
    (для директора также необходима, выводить количество подчинённых). 
Создайте класс Salary, в теле класса создайте метод который должен повышать оклад сотрудников на определенный процент, данный метод 
    должен принимать 2 аргумента, 1-й массив сотрудников, 2-й ето процент повышения.Создайте 4 экземпляра класса сотрудник, 2 экземпляра 
    класса директор, добавьте каждому директору ранее созданных сотрудников. Выведете на консоль оклад каждого сотрудника, используя 
    переопределенный метод ToString(), после чего повысьте всем сотрудникам оклад на 10%, после чего снова выведете информацию о кладах 
    сотрудниках. */

    class Program
    {
        static void Main(string[] args)
        {
            Workman worker1 = new Workman("Iryna",32,"DevOps",20000);
            Workman worker2 = new Workman("Ivan",31,"SysAdmin",9000);
            Workman worker3 = new Workman("Anna",33,"QA",15000);
            Workman worker4 = new Workman("Oleh",30,"HR",10000);

            Director director1 = new Director("Dmytro",32,"Engeneering",40000);
            Director director2 = new Director("Inna",33,"HR",35000);

            director1.Employee[0] = worker1;
            director1.Employee[1] = worker2;

            director2.Employee[0] = worker3;
            director2.Employee[1] = worker4;

            Console.WriteLine(director1.ToString());
            Console.WriteLine(director2.ToString());

            director1.displayEmployeeInfo();
            director2.displayEmployeeInfo();

            Salary salary = new Salary();
            salary.raiseSalary(10,director1,director2,worker1,worker2,worker3,worker4);
            
            Console.ReadLine();
        }
    }
    public class Employee
    {
        private double salary;
        public double Salary 
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string name,int age,double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    public class Workman:Employee
    {
        private string department;
        public string Department 
        {
            get { return department; }
            set { department = value; }
        }
        public Workman(string name,int age,string department,double salary) : base(name, age,salary) { Department = department; }
        
        public override string ToString()
        {
            return Name + " " + Age + "\n" + Department+" department"+"\n"+"Salary: "+Salary+"\n";
        }
    }
    public class Director : Employee
    {
        private Employee[] employee = new Employee[2];
        public Employee [] Employee
        {
            get { return employee; }
            set { employee = value; } 
        }
        private string department;
        public string Department 
        {
            get { return department; }
            set { department = value; }
        }
        public Director(string name, int age, string department, double salary) : base(name, age, salary) { Department = department; }
       
        public override string ToString()
        {
            int counter = 0;
            foreach (var item in employee)
            {
                if(item is Workman) 
                { counter++; }
            }
            return "VP of " + Department + "\n" + Name + " " + Age + "\n" +"Salary: "+Salary+ "\n"+counter + " employees" +"\n"; 
        }
        public void displayEmployeeInfo()
        {
         foreach (var item in Employee)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    public class Salary
    {
        public void raiseSalary(int interest,params Employee[]emp)
        {
            foreach (var item in emp)
            {
                item.Salary = item.Salary* interest / 100 + item.Salary;
                Console.WriteLine(item.ToString());
            }
        }
    }
}

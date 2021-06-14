using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.Создайте программу, в которой создайте два интерфейса 
   IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / 
   void Pause() / void Stop() соответственно. Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. Написать 
   программу, которая выполняет проигрывание и запись*/
   interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable play = new Player();
            IRecordable record = new Player();

            play.Play();
            play.Pause();
            play.Stop();

            record.Record();
            record.Pause();
            record.Stop();

            Console.ReadLine();
        }
    }
    public class Player:IPlayable,IRecordable
    {
        public void Play() => Console.WriteLine("Play");
        void IPlayable.Stop() => Console.WriteLine("Play stopped");
        void IPlayable.Pause() => Console.WriteLine("Play paused");
        public void Record() => Console.WriteLine("Recording");
        void IRecordable.Stop() => Console.WriteLine("Stop recording");
        void IRecordable.Pause() => Console.WriteLine("Pause recording");
    }
}

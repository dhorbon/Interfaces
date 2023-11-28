using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class SimpleCalculator : ICalculator
    {
        public int Add(int x,  int y) {  return x + y; }
        public int Subtract(int x, int y) { return x - y; }
    }

    public class AdvancedCalculator : IOperation, ILogin, IStatistics
    {
        public int Add(int x, int y) { return x + y; }
        public string Login() { return "zalogowano"; }
        public double Statistics { get; }
    }

    public class LaserPrinter : IPrinter
    {
        string IPrinter.Print(string text) { return text; }
        public string Print(int x) { return x.ToString();}
    }

    public class Phone : ISound
    {
        public string MakeASound()
        {
            return "dzwiek dzwonienia";
        }
    }

    public class Car : ISound
    {
        public string MakeASound()
        {
            return "dzwiek silnika";
        }
    }
    /*
    public class User
    {
        string ILogin.Login()
        {
            return "zalogowano";
        }
    }*/

    public class Repo<T> : IRepo<T>
    {
        private List<T> list = new();

        public void Add(T item) {  list.Add(item); }

        public T Get(int id) { return list[id]; }
        public void Update(int id, T item) { list[id] = item; }
        public void Delete(int id) {  list.RemoveAt(id); }
    }

    public class AsyncImplementation : IAsync
    {
        async void IAsync.DoAsync()
        {
            await Task.Delay(1000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICalculator
    {
        public int Add(int x, int y);
        public int Subtract(int x, int y);
    }

    public interface ILogin
    {
        public string Login();
    }

    public interface IOperation
    {
        public int Add(int x, int y);
    }

    public interface IStatistics
    {
        public double Statistics { get; }
    }

    public interface IPrinter
    {
        public string Print(string text);
    }

    public interface ISound
    {
        public string MakeASound();
    }

    public interface IRepo<T>
    {
        public void Add(T item);
        public T Get(int id);
        public void Update(int id, T item);
        public void Delete(int id);
    }

    public interface IAsync
    {
        public void DoAsync();
    }
}

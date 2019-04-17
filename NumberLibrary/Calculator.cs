using System;
using System.Diagnostics;

namespace NumberLibrary
{
    public interface IPrimeService
    {
        bool IsPrime(int num);
    }

    public interface ISquareService
    {
        bool isSquareNumber(double num);
        int squared(int num);
    }

    public interface IAddService
    {
        int add(int num, int num2);
    }
    public interface ISubtractService
    {
        int subtract(int num);
    }

    public class Calculator : IPrimeService, ISquareService, IAddService, ISubtractService
    {
       /// <summary>
       /// Adds two numbers together
       /// </summary>
       /// <param name="num"></param>
       /// <param name="num2"></param>
       /// <returns></returns>
        public int add(int num, int num2)
        {
            return num + num2;
        }

        public bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            throw new NotImplementedException();
        }

        public bool isSquareNumber(double num)
        {
            var result = Math.Sqrt(num);
            bool isInt = result == (int)result;
            return isInt;
        }

        public int squared(int num)
        {
            return num * num;
        }

        public int subtract(int num)
        {
            throw new NotImplementedException();
        }
    }
}

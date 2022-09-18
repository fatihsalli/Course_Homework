using BLL.Service;
using DataAccess.Entity;
using System;
using System.Collections.Generic;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AttachService service = new AttachService();

            foreach (int number in service.RandomNumber())
            {
                Console.WriteLine(number);
            }

        }
    }
}

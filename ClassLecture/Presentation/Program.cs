using BLL.Service;
using DataAccess.Container;
using DataAccess.Entity;
using System;
using System.Collections.Generic;

namespace Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AttachService attachService = new AttachService();
            //BaseService<Student> baseServiceStu=new BaseService<Student>();
            //BaseService<Topic> baseServiceTop = new BaseService<Topic>();

            //Console.WriteLine(baseServiceTop.DataTransmission(TemporaryDb.topics));

            //List<Student> newstudents = attachService.AttachTopic(TemporaryDb.students, attachService.RandomNumber());
            //Console.WriteLine(baseServiceStu.DataTransmission(newstudents));

            StudentRepository studentRepository = new StudentRepository();
            studentRepository.GetListMixed();
            Console.Read();

        }
    }
}

using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Container
{
    public class TemporaryDb
    {
        public static List<Topic> topics = new List<Topic>()
            {
                new Topic{Id=1,TopicName="SQL-Database,Tablo ve Diyagram Oluşturma"},
                new Topic{Id=2,TopicName="SQL-Aggregate Fonksiyonlar,Like,Where"},
                new Topic{Id=3,TopicName="SQL-Insert-Update-Delete ve Join"},
                new Topic{Id=4,TopicName="C# Intro-If,Else,Else If ve Switch Case"},
                new Topic{Id=5,TopicName="C# Intro-While,For,Do while ve Foreach"},
                new Topic{Id=6,TopicName="C# Intro-Method,Sınıf ve Erişim Belirleyici"},
                new Topic{Id=7,TopicName="C# OOP-Abstraction(Soyutlama)"},
                new Topic{Id=8,TopicName="C# OOP-Polymorphism(Çok Biçimlilik)"},
                new Topic{Id=9,TopicName="C# OOP-İnheritance(Kalıtım)"},
                new Topic{Id=10,TopicName="C# OOP-Abstraction(Soyutlama)"},
                new Topic{Id=11,TopicName="C# OOP-Contruction Method ve Interface"},
                new Topic{Id=12,TopicName="DataAccess-Entity Framework-Code First"},
                new Topic{Id=13,TopicName="DataAccess-Entity Framework-Db First"},
                new Topic{Id=14,TopicName="SOLID-S:Single Responsibility Principle (SRP)"},
                new Topic{Id=15,TopicName="SOLID-O:Open Closed Principle (OSP)"},
                new Topic{Id=16,TopicName="SOLID-L:Liskov Substitution Principle (LSP)"},
                new Topic{Id=17,TopicName="SOLID-I:Interface Segregation Principle (ISP)"},
                new Topic{Id=18,TopicName="SOLID-D:Dependency Inversion Principle (DIP)"},
                new Topic{Id=19,TopicName="Design Patterns:Singleton"},
                new Topic{Id=20,TopicName="Design Patterns:Factory Pattern"},
            };

        public static List<Student> students = new List<Student>()
            {
                new Student{Id=1,FirstName="Berkay",Lastname="Yıldırım"},
                new Student{Id=2,FirstName="Bilal",Lastname="Kara"},
                new Student{Id=3,FirstName="Doğukan",Lastname="Blknc"},
                new Student{Id=4,FirstName="Emir",Lastname="Güven"},
                new Student{Id=5,FirstName="Emre",Lastname="Gözke"},
                new Student{Id=6,FirstName="Fatih",Lastname="Şallı"},
                new Student{Id=7,FirstName="Ferhat",Lastname="Harun"},
                new Student{Id=8,FirstName="İbrahim",Lastname="Sarıkaya"},
                new Student{Id=9,FirstName="İrem",Lastname="Tuncer"},
                new Student{Id=10,FirstName="Kürşat",Lastname="Mezireli"},
                new Student{Id=11,FirstName="M.Can",Lastname="Bozbuğa"},
                new Student{Id=12,FirstName="Meriç",Lastname="Aydoğan"},
                new Student{Id=13,FirstName="Özgür",Lastname="Okumuş"},
                new Student{Id=14,FirstName="Sadık",Lastname="Akgedik"},
                new Student{Id=15,FirstName="Sait",Lastname="Sait47"},
                new Student{Id=16,FirstName="Strano",Lastname="Artista"},
                new Student{Id=17,FirstName="Umut",Lastname="Yılbas"},
                new Student{Id=18,FirstName="Enes",Lastname="Albayrak"},
            };


    }
}

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
                new Topic{TopicName="SQL-Database,Tablo ve Diyagram Oluşturma"},
                new Topic{TopicName="SQL-Aggregate Fonksiyonlar,Like,Where"},
                new Topic{TopicName="SQL-Insert-Update-Delete ve Join"},
                new Topic{TopicName="C# Intro-If,Else,Else If ve Switch Case"},
                new Topic{TopicName="C# Intro-While,For,Do while ve Foreach"},
                new Topic{TopicName="C# Intro-Method,Sınıf ve Erişim Belirleyici"},
                new Topic{TopicName="C# OOP-Abstraction(Soyutlama)"},
                new Topic{TopicName="C# OOP-Polymorphism(Çok Biçimlilik)"},
                new Topic{TopicName="C# OOP-İnheritance(Kalıtım)"},
                new Topic{TopicName="C# OOP-Abstraction(Soyutlama)"},
                new Topic{TopicName="C# OOP-Contruction Method ve Interface"},
                new Topic{TopicName="DataAccess-Entity Framework-Code First"},
                new Topic{TopicName="DataAccess-Entity Framework-Db First"},
                new Topic{TopicName="SOLID-S:Single Responsibility Principle (SRP)"},
                new Topic{TopicName="SOLID-O:Open Closed Principle (OSP)"},
                new Topic{TopicName="SOLID-L:Liskov Substitution Principle (LSP)"},
                new Topic{TopicName="SOLID-I:Interface Segregation Principle (ISP)"},
                new Topic{TopicName="SOLID-D:Dependency Inversion Principle (DIP)"},
                new Topic{TopicName="Design Patterns:Singleton"},
                new Topic{TopicName="Design Patterns:Factory Pattern"},
            };

        public static List<Student> students = new List<Student>()
            {
                new Student{FirstName="Berkay",Lastname="Yıldırım"},
                new Student{FirstName="Bilal",Lastname="Kara"},
                new Student{FirstName="Doğukan",Lastname="Blknc"},
                new Student{FirstName="Emir",Lastname="Güven"},
                new Student{FirstName="Emre",Lastname="Gözke"},
                new Student{FirstName="Fatih",Lastname="Şallı"},
                new Student{FirstName="Ferhat",Lastname="Harun"},
                new Student{FirstName="İbrahim",Lastname="Sarıkaya"},
                new Student{FirstName="İrem",Lastname="Tuncer"},
                new Student{FirstName="Kürşat",Lastname="Mezireli"},
                new Student{FirstName="M.Can",Lastname="Bozbuğa"},
                new Student{FirstName="Meriç",Lastname="Aydoğan"},
                new Student{FirstName="Özgür",Lastname="Okumuş"},
                new Student{FirstName="Sadık",Lastname="Akgedik"},
                new Student{FirstName="Sait",Lastname="Sait47"},
                new Student{FirstName="Strano",Lastname="Artista"},
                new Student{FirstName="Umut",Lastname="Yılbas"},
                new Student{FirstName="Enes",Lastname="Albayrak"},
            };


    }
}

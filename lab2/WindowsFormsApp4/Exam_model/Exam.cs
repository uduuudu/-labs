using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
                                            Задача 2. Полиморфизм 
Задание: построить класс 1-го уровня с указанными в индивидуальном задании полями и методами: 
конструктор; 
функция, которая определяет «качество» объекта – Q  по заданной формуле (столбец 2); 
вывод информации об объекте.   
Построить класс 2-го уровня (класс-потомок), который содержит: 
дополнительное поле P; 
функция, которая определяет «качество» объекта класса 2-го уровня – Qp, которая перекрывает функцию качества класса 1-го уровня (Q ), выполняя вычисление по новой формуле (столбец 3).  
Создать проект для демонстрации работы: ввод и вывод информации об объектах классов 1-го и 2-го уровней. 

8. Экзамен: 
дисциплина; 
число студентов на экзамене;    - продолжительность экзамена (ч). 
Q = число студентов / продолжительность
P: процент двоек  
 
 
Qp = Q· ( 100-Р)/100 


*/
namespace WindowsFormsApp4
{
     public class Exam
    {
        public string Subject { get; set;}
        public int count_students { get; set; }
        public int count_hours { get; set; }
        public Exam(string s, int c1, int c2) // конструктор
        {
            Subject = s;
            count_students = c1;
            count_hours = c2;
        }
        public virtual double Q() // функция "качества"
        {
            return count_students / Convert.ToDouble(count_hours); 
        }

        
        public virtual string print() // вывод информации об объекте
        {
            return $"Экзамен по дисциплине {Subject}, количество сдающих студентов - {count_students}, количество часов - {count_hours}, качество - {Q()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class MyClass
    {
        /// <summary>
        /// внутренние нестатические поля вещественного типа с именем value1, value2
        /// </summary>
        private double value1;
        public double value2;
        /// <summary>
        /// открытое целочисленное статическое поле с именем count для подсчета созданных экземпляров класса
        /// </summary>
        static int count;
        /// <summary>
        /// нестатический конструктор с двумя параметрами, который инициализирует одноименные внутренние поля класса
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        public MyClass(double value1, double value2)
        {
           this.value1 = value1;
           this.value2 = value2;
        }
        /// <summary>
        /// нестатический конструктор без параметров, который инициализирует внутренние поля класса значением 2.0
        /// </summary>
        public MyClass()
        {
             this.value1 = 2.0;
             this.value2 = 2.0;
        }
        /// <summary>
        /// статический конструктор, который инициализирует статическую переменную count нулевым значением
        /// </summary>
        static MyClass()
        {
             int count = 0;
        }
        /// <summary>
        /// свойства для доступа к внутренним полям класса
        /// </summary>
        public double value1
        {
                get => value1;
                set => value1 = value;
        }
            public double Value12
            {
                get => value2;
                set => value2 = value;
            }

            public void Class()
            {
              Console.WriteLine("value1 = " + value1);
              Console.WriteLine("value2 = " + value2);
            }
    }
}

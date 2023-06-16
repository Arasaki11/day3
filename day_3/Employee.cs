using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_3
{
    internal class Employee
    {
        private string _fio;
        private double _wages;
        private int _department;
        private int _id = 0;

        static int count;
        public int Id()
        {
            _id++;
            count = _id;
            return count;
        }

        public Employee(string fio, double wages, int department)
        {
            _fio = fio;
            _wages = wages;
            _department = department;
        }
        public string fio
        {
            get => _fio;
            set => _fio = value;
        }
        public double wages
        {
            get => _wages;
            set => _wages = value;
        }
        public int department
        {
            get => _department;
            set => _department = value;
        }
    }
}

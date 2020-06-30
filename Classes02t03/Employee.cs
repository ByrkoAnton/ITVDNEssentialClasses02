using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Classes02t03
{
    class Employee
    {
        private string _name;
        private string _lastName;
        private string _position;
        private byte _experienceInYears;
        private int _selarry;

        public Employee(string name, string LastName)
        {
            _name = name;
            _lastName = LastName;
            _position = null;
            _experienceInYears = 0;
            _selarry = 0;
        }

        public string Position
        {
            set
            {
                _position = value;
                if (value == "driver")
                    _selarry = 100;

                if (value == "manager")
                    _selarry = 300;

                if (value == "boss")
                    _selarry = 500;
            }
        }

        public byte ExperienceInYears
        {
            set
            {
                _experienceInYears = value;
            }
        }

        public double CalculateSelaryWithExperienceAndTaxes(double taxes)
        {
            if (_experienceInYears > 0)
                return _experienceInYears * 10 + _selarry - ((_experienceInYears * 10 + _selarry) * (taxes / 100));

            return _selarry - _selarry * (taxes / 100);
        }

        public string GetWorkerInfo()
        {
            return $"Name - {_name}\nLast name - {_lastName}\nPosition - {_position}\n" +
                $"Selary - {_selarry}";
        }
    }
}

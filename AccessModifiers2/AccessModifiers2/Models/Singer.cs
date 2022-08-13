using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2.Models
{
    class Singer
    {
        //fields
        private string _name;
        private string _surname;
        private int _age;



        //prop
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 101)
                    _name = value;
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (value.Length < 101)
                    _surname = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value < 171)
                    _age = value;
            }
        }




        //ctor
        public Singer()
        {

        }
        public Singer(string name)
        {
            Name = name;
        }
        public Singer(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Singer(string name, string surname, int age) : this(surname)
        {
            Age = age;
        }

    }
}

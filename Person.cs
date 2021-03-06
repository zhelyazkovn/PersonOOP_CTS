//Create a class Person with two fields – name and age. Age can be left unspecified 
//    (may contain null value. Override ToString() to display the information of a person 
//        and if age is not specified – to say so. Write a program to test this functionality.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PersonDemo
{
    public class Person
    {
        private string name;
        private int? age; //we define age with "int?" in order to make it nullable

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))//ensure the value of the name
                {
                    throw new ArgumentException("name");
                } 
                this.name = value; //if the name is ok set the value to it
            }
        }

        public int? Age //nullable type for Age property
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person() //constructor
        {
            this.Name = "Svetlin Nakov";
            this.Age = null;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nAge: {1}",
                this.Name, this.Age != null ? this.Age.ToString() : "Undefined");
        }
    }
}

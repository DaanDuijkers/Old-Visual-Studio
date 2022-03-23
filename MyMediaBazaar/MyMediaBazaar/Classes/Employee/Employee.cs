using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaBazaar
{
    public class Employee
    {
        private int id, bsn, hours;
        private double wage;
        private bool active;
        private Gender gender;
        private Role role;
        private Department department;
        private DateTime birthDate;
        private string firstName, surName, email, phone, address, postal, town, username, password, contactName, contactPhone;

        public int ID { get { return this.id; } }
        public int BSN { get { return this.bsn; } }
        public int Hours { get { return this.hours; } set { this.hours = value; } }
        public Department Department { get { return this.department; } set { this.department = value; } }
        public double Wage { get { return this.wage; } set { this.wage = value; } }
        public bool Active { get { return this.active; } set { this.active = value; } }
        public Gender Gender { get { return this.gender; } set { this.gender = value; } }
        public Role Role { get { return this.role; } set { this.role = value; } }
        public DateTime BirthDate { get { return this.birthDate; } set { this.birthDate = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string SurName { get { return this.surName; } set { this.surName = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string Postal { get { return this.postal; } set { this.postal = value; } }
        public string Town { get { return this.town; } set { this.town = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string ContactName { get { return this.contactName; } set { this.contactName = value; } }
        public string ContactPhone { get { return this.contactPhone; } set { this.contactPhone = value; } }

        public Employee (int id, int bsn, int hours, Department department, double wage, bool active, Gender gender, Role role, DateTime birthDate, string firstName, string surName, string email, string phone, string address, string postal, string town, string username, string password, string contactName, string contactPhone)
        {
            this.id = id;
            this.bsn = bsn;
            this.hours = hours;
            this.department = department;
            this.wage = wage;
            this.active = active;
            this.gender = gender;
            this.role = role;
            this.birthDate = birthDate;
            this.firstName = firstName;
            this.surName = surName;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.postal = postal;
            this.town = town;
            this.username = username;
            this.password = password;
            this.contactName = contactName;
            this.contactPhone = contactPhone;
        }
    }
}
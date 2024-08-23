using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLicenseManagement.BL.Models
{
    internal class Person
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { set; get; }
        public string NationalNo { get; set; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public string Gendor { get; set; }
        public DateTime DateOfBirth { set; get; }
        //public string Nationality { get; set; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }

        public string ImageName { set; get; }

        public int CountryID { set; get; }

        public Person(int iD, string nationalNo, string firstName, string secondName,
                      string thirdName, string lastName, string gendor, DateTime dateOfBirth,
                      string phone, string email, string address, string imageName, int countryID)
        {
            Mode = enMode.Update;
            ID = iD;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gendor = gendor;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Email = email;
            Address = address;
            ImageName = imageName;
            CountryID = countryID;
        }


        public Person()
        {
            Mode = enMode.AddNew;
            ID = -1;
            NationalNo = "";
            FirstName  = "";
            SecondName = "";
            ThirdName  = "";
            LastName   = "";
            Gendor     = "";
            DateOfBirth = DateTime.Now;
            Phone = "";
            Email = "";
            Address = "";
            ImageName = "";
            CountryID = -1;
        }

         
    }
}

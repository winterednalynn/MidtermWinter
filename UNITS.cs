using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermWinter
{
    public class UNITS
    {
        //FIELDS 
        string _ApartmentNumber;
        string _FirstName;
        string _LastName;
        decimal _MonthlyPayment;
        float _numOfBedrooms;
        string _ApartmentNotes;
        bool isOccupied;

        public UNITS(string apartmentNumber)
        {
            Random rand = new Random();

            _ApartmentNumber = rand.Next(1, 10).ToString();

            isOccupied = true;

        }
        //OVERLOADING 
        public UNITS(string apartmentNumber, bool isOccupied)
        {
            Random rand = new Random();

            _ApartmentNumber = rand.Next(1, 10).ToString();

            isOccupied = false;
        }



        public UNITS(string apartmentNumber, string firstName, string lastName, decimal monthlyPayment, float numOfBedrooms)
        {
            _ApartmentNumber = apartmentNumber;
            _FirstName = firstName;
            _LastName = lastName;
            _MonthlyPayment = monthlyPayment;
            _numOfBedrooms = numOfBedrooms;



        }



        public string ApartmentNumber { get => _ApartmentNumber; set => _ApartmentNumber = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public decimal MonthlyPayment { get => _MonthlyPayment; set => _MonthlyPayment = value; }
        public float NumOfBedrooms { get => _numOfBedrooms; set => _numOfBedrooms = value; }
        public string ApartmentNotes { get => _ApartmentNotes; set => _ApartmentNotes = value; }
        public bool IsOccupied { get => isOccupied; set => isOccupied = value; }

        public override string ToString()
        {


            if (IsOccupied)
            {
                return $"S{_ApartmentNumber}: Vacant";
            }
            else
            {
                return $"S{_ApartmentNumber}: Unavailable";
            }
        }
    }
}

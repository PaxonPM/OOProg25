using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionCheck
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _regNo;
        private int _horsePower;
        private int _doors;



        public string Brand
        {
            get { return _brand; }
            set
            {
                try
                {
                    if (_brand == null) throw new ArgumentNullException("No Brand name returned");
                    if (_brand == "") throw new ArgumentException("Returned an empty string");
                    _brand = value;
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"[Error]: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                try
                {
                    if (_model == null) throw new ArgumentNullException("Returned null for Model");
                    if (_model.Length > 20) throw new ArgumentOutOfRangeException("Model name is to long");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"[Error]: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }
            }
        }
        public string RegNo
        {
            get { return _regNo; }
            set
            {
                try
                {
                    if (_regNo == null) throw new ArgumentNullException("Reg nummer returnerede null");
                    if (_regNo.Length != 7) throw new ArgumentOutOfRangeException("RegNo is not 7 characters long");

                    string pattern = @"^[A-Z]{2}[1-9][0-9]{4}$";

                    if (!Regex.IsMatch(_regNo, pattern)) throw new ArgumentException(" Reg number is outside range A-X,A-X,1-9, 0-9, 0-9, 0-9, 0-9 fx ”AB12456”");

                }
                catch(Exception ex)
                {
                    Console.WriteLine($"[Error]: {ex.Message}\nStackTrace: {ex.StackTrace}");
                }


            }

        }
        public int HorsePower
        {
            get { return _horsePower; }
            set
            {
                if (_horsePower <= 0) throw new ArgumentOutOfRangeException("Should be bigger than 0");
            }
        }
        public int Doors
        {
            get { return _doors; }
            set
            {
                if (_doors < 3 || _doors > 5) throw new ArgumentOutOfRangeException("Der skal være minimum 2 og max 5 døre");
            }
        }
    }
}

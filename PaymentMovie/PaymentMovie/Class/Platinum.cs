using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie.Class
{
    class Platinum : MainUser
    {
        private readonly string _userType;
        private readonly string _promotion;
        public string _movieNam;
        public string _hour;
        public string _seatNumber;
        public string _roomNumber;
        public Platinum(string MovieNam, string Hour, string SeatNumber, string RoomNumber)
        {
            _userType = "Platinum";
            _promotion = "30%"; 
            _movieNam = MovieNam;
            _hour = Hour;
            _seatNumber = SeatNumber;
            _roomNumber = RoomNumber;
        }
        public override string UserType
        {
            get { return _userType; }
        }

        public override string Promotion
        {
            get { return _promotion; }

        }

        public override string MovieNam
        {
            get { return _movieNam; }
            set { _movieNam = value; }
        }
        public override string Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        public override string SeatNumber
        {
            get { return _seatNumber; }
            set { _seatNumber = value; }
        }
        public override string RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }
    }
}

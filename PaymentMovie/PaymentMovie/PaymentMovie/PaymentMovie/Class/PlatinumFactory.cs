using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    class PlatinumFactory: UserFactory
    {
        public string _movieNam;
        public string _hour;
        public string _seatNumber;
        public string _roomNumber;
        public PlatinumFactory(string MovieNam, string Hour, string SeatNumber, string RoomNumber)
        {
            _movieNam = MovieNam;
            _hour = Hour;
            _seatNumber = SeatNumber;
            _roomNumber = RoomNumber;

        }
        public override MainUser GetUserType()
        {
            return new Platinum(_movieNam, _hour, _seatNumber, _roomNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    abstract class MainUser
    {
        public abstract string UserType { get; }
        public abstract string Promotion { get; }
        public abstract string MovieNam { get; set; }
        public abstract string Hour { get; set; }
        public abstract string SeatNumber { get; set; }
        public abstract string RoomNumber { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMovie
{
    abstract class UserFactory
    {
        public abstract MainUser GetUserType();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdCardDetail
{
    class Staff : CardDetail
    {

        String _designation;
        public Staff(string name, string address, long phoneNumber, string designation) : base(name,address,phoneNumber)
        {
            this._designation = designation;
        }


        public Staff(string name, string address, long phoneNumber , string dob, string designation) : base(name, address,dob, phoneNumber)
        {
            this._designation = designation;
        }




    }
}

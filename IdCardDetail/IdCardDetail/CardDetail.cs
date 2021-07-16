using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdCardDetail
{
   public abstract class CardDetail
    {
        private String _name, _address, _dob;
        private long _phoneNumber;


        public CardDetail(String name ,string address , long phoneNumber)
        {
            this._name = name;
            this._address = address;
            this._phoneNumber = phoneNumber;
        }

        public CardDetail(String name, string address, string dob, long phoneNumber) : this(name,address,phoneNumber)
        {

            this._dob = dob;
        

        }
        //public CardDetail(String name, String address, string dob, long phoneNumber) : this(name, address, dob)
        //{

        //    this._phoneNumber = phoneNumber;

        





    }
}

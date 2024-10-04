using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceApp
{
    internal interface IPayment
    {
        string paymentID { get; set; }

        string payment(int amount);

    }

    class HDFCService : IPayment
    {
        public string paymentID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string payment(int amount)
        {

            return "";
        }
    }
}

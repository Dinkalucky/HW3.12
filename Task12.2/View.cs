using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task12._2
{
    public class CustomerView : ICustomerView
    {
        int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int OrderHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICustomerView ICustomerView
        {
            get => default;
            set
            {
            }
        }

        event EventHandler SaveCustomer
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }
    }
}
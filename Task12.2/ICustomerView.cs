using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task12._2
{
    public interface ICustomerView
    {
        event EventHandler SaveCustomer;

        int ID { get; set; }
        int Name { get; set; }
        int OrderHistory { get; set; }
    }
}
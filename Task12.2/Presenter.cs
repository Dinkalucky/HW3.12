using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task12._2
{
    public class CustomerPresenter
    {
        public CustomerView CustomerView
        {
            get => default;
            set
            {
            }
        }

        public CustomerModel CustomerModel
        {
            get => default;
            set
            {
            }
        }

        public void BindModel()
        {
            throw new System.NotImplementedException();
        }

        public void GetModel()
        {
            throw new System.NotImplementedException();
        }

        public void SubscribeToEvent()
        {
            throw new System.NotImplementedException();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    public class Name
    {
        private string _title;
        private string _firstName;
        private string _lastName;

        public Name(string firstName, string lastName)
        {
            _title = "";
            _firstName = firstName;
            _lastName = lastName;
        }

        public Name(string title, string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Views
{
    public class CurrentPerson
    {
        private CurrentPerson() { }
        public Person person;
        public static CurrentPerson instance;
        public static CurrentPerson getInstance()
        {
            if (instance == null)
            {
                instance = new CurrentPerson();
            }
            return instance;
        }
    }
}

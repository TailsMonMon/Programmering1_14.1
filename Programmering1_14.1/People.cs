using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_14._1 {
    class Person {
        private string personName = "";
        private long personSocialSecurityNumber = 0;

        public Person (string name, long number) {
            this.personName = name;
            this.personSocialSecurityNumber = number;
        }

        public string Name {
            get { return personName; }
            set { personName = value; }
        }

        public long Number {
            get { return personSocialSecurityNumber; }
            set { personSocialSecurityNumber = value; }
        }
        
    }
}

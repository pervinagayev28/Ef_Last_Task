using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
   public  class Debtor
    {
        public Debtor(int Id, string fullname, DateTime birthDay, string phone, string email, string address, int debt) { this.Id = Id; this.FullName = fullname; this.BirthDay = birthDay; this.Phone = phone; this.Email = email; this.Address = address; this.Debt = debt; }

        public Debtor()
        {
            
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }
        public override string ToString() { return $"{this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}"; }
    }
}

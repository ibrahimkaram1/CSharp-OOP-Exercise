using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system1
{
    public class LibraryCard
    {
        public string CardNumber { get; set; }
        public string UserName { get; set; }
        public DateTime ExpirationDate { get; set; }

        public LibraryCard(string cardNumber, string userName, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            UserName = userName;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Library Card: {CardNumber}, User: {UserName}, Expires: {ExpirationDate.ToShortDateString()}";
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }
    }

}

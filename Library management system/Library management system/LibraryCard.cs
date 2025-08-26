using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal class LibraryCard
    {
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsValid => DateTime.Now < ExpirationDate;
        public LibraryCard()
        {
            CardNumber = GenerateCardNumber();
            ExpirationDate = DateTime.Now.AddYears(1); // Default to 1 year validity
        }
        private string GenerateCardNumber()
        {
            return Guid.NewGuid().ToString(); // Simple unique identifier for the card
        }
    }
}

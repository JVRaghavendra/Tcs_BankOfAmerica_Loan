﻿namespace Tcs_BankOfAmerica_Loan.Entities
{
    public class Booking
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string CustomerName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
//@Email varchar(max),@CustomerName varchar(max),@Country varchar(max),
//@City varchar(max))
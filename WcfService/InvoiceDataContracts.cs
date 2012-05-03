using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class Invoice
    {
        // Header
        public Guid Id { set; get; }
        public Warning Warning { set; get; }
        public Location Location { set; get; }
        public Customer Customer { set; get; }
        public Bed Bed { set; get; }
        public User User { set; get; }
        public string InvoiceNo { set; get; }
        public Address Address { set; get; }
        // Lazy load lists. Note for service developer: Use these if you plan to embed load logic in the invoice.
        //public IEnumerable<Note> History { set; get; }
        //public IEnumerable<Phone> Phones { set; get; }
        //public IEnumerable<Email> Emails { set; get; }
        //public IEnumerable<Address> Addresses { set; get; }
        //public IEnumerable<PurchasedService> PurchasedServices { set; get; }
        //public IEnumerable<Payment> Payments { set; get; }
    }

    #region Invoice Properties

    [DataContract]
    public class Warning
    {
        public int Severity { set; get; }

        public string Text { set; get; }
    }

    [DataContract]
    public class Service
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public decimal Rate { set; get; }
        public decimal Fee { set; get; }
        public decimal Cap { set; get; }
    }

    [DataContract]
    public class Bed
    {
        public string Poc { set; get; }
        public string Room { set; get; }
        public string Text { set; get; }
        public string Extension { set; get; }
    }

    [DataContract]
    public class User
    {
        public string Initials { set; get; }
    }

    [DataContract]
    public class Note
    {
        public DateTime Date { set; get; }
        public string Text { set; get; }
        public User User { set; get; }
    }

    [DataContract]
    public class Phone
    {
        public string Number { set; get; }
        public int Status { set; get; }
        public DateTime StatusDate { set; get; }
    }

    [DataContract]
    public class Email
    {
        public string Address { set; get; }
        public DateTime LastAction { set; get; }
    }

    public class Address
    {
        public int Id { set; get; }
        public string Street1 { set; get; }
        public string Street2 { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Postal { set; get; }
        public int Priority { set; get; }
    }

    public class PurchasedService
    {
        public Service Service { set; get; }
        public Bed Bed { set; get; }
        public DateTime Day { set; get; }
    }

    public class Customer
    {
        public string Name { set; get; }
    }

    public class Location
    {
        public string Name { set; get; }
        public string InstructionsUrl { set; get; }
        public DateTime Start { set; get; }
        public string Phone { set; get; }
        public IEnumerable<Service> AvailableServices { set; get; }
    }

    public class Payment
    {
        public string Type { set; get; }
        public string Ref { set; get; }
        public decimal Amount { set; get; }
    }

    #endregion

    #region Payment types

    public class CreditCard
    {
        public string NameOnCard { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Number { set; get; }
        public string Expires { set; get; }
        public string Csc { set; get; }
        public Address Address { set; get; }
    }

    /// <summary>
    /// Pre-paid Card
    /// </summary>
    public class PrePaidCard
    {
        public string Number { set; get; }
        public decimal Amount { set; get; }
    }

    /// <summary>
    /// Chargable phone
    /// </summary>
    public class PhonePay
    {
        public string Number { set; get; }
    }

    #endregion
}
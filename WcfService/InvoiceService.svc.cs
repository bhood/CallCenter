using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    /// <summary>
    /// Invoice Service
    /// </summary>
    public class InvoiceService : IInvoiceService
    {
        public Invoice GetInvoice(Guid id)
        {
            throw new NotImplementedException();
        }

        public string GetReturnUrl(Guid invoiceId)
        {
            throw new NotImplementedException();
        }

        public Invoice GetHeader(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetHistory(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Phone> GetPhontes(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Email> GetEmails(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddresses(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PurchasedService> GetPurchasedServices(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Payment> GetPayments(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public string GetReview(Invoice invoice)
        {
            throw new NotImplementedException();
        }

        public void AddNote(Invoice invoice, Note note)
        {
            throw new NotImplementedException();
        }

        public void AddAddress(Invoice invoice, Address address)
        {
            throw new NotImplementedException();
        }

        public void AddPhone(Invoice invoice, Phone phone)
        {
            throw new NotImplementedException();
        }

        public void AddEmail(Invoice invoice, Email email)
        {
            throw new NotImplementedException();
        }

        public void AddService(Invoice invoice, PurchasedService service)
        {
            throw new NotImplementedException();
        }

        public void AddPayment(Invoice invoice, CreditCard card)
        {
            throw new NotImplementedException();
        }

        public void AddPayment(Invoice invoice, PrePaidCard card)
        {
            throw new NotImplementedException();
        }

        public void AddPayment(Invoice invoice, PhonePay phone)
        {
            throw new NotImplementedException();
        }

        public bool GetApproval(PrePaidCard card)
        {
            throw new NotImplementedException();
        }

        public bool GetApproval(CreditCard card)
        {
            throw new NotImplementedException();
        }

        public bool GetApproval(PhonePay phone)
        {
            throw new NotImplementedException();
        }

    }
}

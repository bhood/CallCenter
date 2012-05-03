using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    /// <summary>
    /// Invoice service interface
    /// </summary>
    /// <remarks>
    /// Assumes Id is set for the invoice parameter in all sets and gets.
    /// </remarks>
    [ServiceContract]
    public interface IInvoiceService
    {
        #region Page Gets
        /// <summary>
        /// Developer Note: This method is optional. It is only needed if values other than the public Id field are used in any of the other operations.
        /// </summary>
        /// <param name="id">The Guid of the invoice. This is passed as a Querystring in the interface Url.</param>
        /// <returns>A blank invoice with the ID fields filled in.</returns>
        [OperationContract]
        Invoice GetInvoice(Guid id);

        /// <summary>
        /// Gets the return URL used in the invoice interface based on the invoice id passed in the querystring.
        /// </summary>
        /// <param name="invoiceId">The Guid of the invoice. This is passed as a Querystring in the interface Url.</param>
        /// <returns>A relative URL as a string.</returns>
        [OperationContract]
        string GetReturnUrl(Guid invoiceId);

        #endregion

        #region Approvals

        /// <summary>
        /// Get approval for a pre-paid card
        /// </summary>
        /// <param name="card">The pre-paid card to approve.</param>
        /// <returns><c>true</c> if the card is approved.</returns>
        [OperationContract]
        bool GetApproval(PrePaidCard card);

        /// <summary>
        /// Get approval for a credit card.
        /// </summary>
        /// <param name="card">The card to approve.</param>
        /// <returns><c>true</c> if the card is approved.</returns>
        [OperationContract]
        bool GetApproval(CreditCard card);

        #endregion

        /// <summary>
        /// Get approval for a chargable phone number.
        /// </summary>
        /// <param name="phone">The phone to approve.</param>
        /// <returns><c>true</c> if the phone is approved.</returns>
        [OperationContract]
        bool GetApproval(PhonePay phone);

        #region Invoice Gets

        /// <summary>
        /// Fills in all of the header fields for the supplied invoice and returns it.
        /// </summary>
        /// <param name="invoice">The invoice to populate.</param>
        /// <returns>The passed invoice with all header fields populated.</returns>
        [OperationContract]
        Invoice GetHeader(Invoice invoice);

        /// <summary>
        /// Get the list of notes associated with the invoice.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<Note> GetHistory(Invoice invoice);

        /// <summary>
        /// Get the list of phones associated with the invoice.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<Phone> GetPhontes(Invoice invoice);

        /// <summary>
        /// Get the list of e-mails associated with the invoice.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<Email> GetEmails(Invoice invoice);

        /// <summary>
        /// Get the list of addresses associated with the invoice.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<Address> GetAddresses(Invoice invoice);

        /// <summary>
        /// Get the list of purchased services associated with the invoice.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<PurchasedService> GetPurchasedServices(Invoice invoice);

        /// <summary>
        /// Get the list of payments associated with the invoice
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        [OperationContract]
        IEnumerable<Payment> GetPayments(Invoice invoice);

        /// <summary>
        /// Get the text for the invoice Review section.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <remarks>The text is based on invoice transactions for today.</remarks>
        [OperationContract]
        string GetReview(Invoice invoice);

        #endregion

        #region Puts

        /// <summary>
        /// Add a note to the invoice history list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="note">The note to add.</param>
        [OperationContract]
        void AddNote(Invoice invoice, Note note);

        /// <summary>
        /// Add an address to the invoice address list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="address">The address to add.</param>
        [OperationContract]
        void AddAddress(Invoice invoice, Address address);

        /// <summary>
        /// Add a phone to the invoice phone list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="phone">The phone to add.</param>
        /// <remarks></remarks>
        [OperationContract]
        void AddPhone(Invoice invoice, Phone phone);

        /// <summary>
        /// Add an email to the invoice email list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="email">The email to add.</param>
        [OperationContract]
        void AddEmail(Invoice invoice, Email email);

        /// <summary>
        /// Add a purchased service to the invoice services list
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="service">The purchased service to add.</param>
        [OperationContract]
        void AddService(Invoice invoice, PurchasedService service);

        /// <summary>
        /// Add a credit card payment to the payment list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="card">The credit card to add a payment for.</param>
        [OperationContract]
        void AddPayment(Invoice invoice, CreditCard card);

        /// <summary>
        /// Add a pre-paid card to the invoice payment list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="card">The pre-paid card to add a payment for.</param>
        [OperationContract]
        void AddPayment(Invoice invoice, PrePaidCard card);

        /// <summary>
        /// Add a pre-paid card to the invoice payment list.
        /// </summary>
        /// <param name="invoice">A blank invoice with the Id field(s) set.</param>
        /// <param name="phone">The phone to add a payment for.</param>
        [OperationContract]
        void AddPayment(Invoice invoice, PhonePay phone);

        #endregion

    }
}

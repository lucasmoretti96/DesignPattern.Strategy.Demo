using DesignPattern.Strategy.Demo.Business.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace DesignPattern.Strategy.Demo.Business.Strategies.Invoice
{
    public class EmailInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            using (SmtpClient client = new SmtpClient("smtp.sendgrid.net", 587))
            {
                NetworkCredential credential = new NetworkCredential("USERNAME", "PASSWORD");
                client.Credentials = credential;

                MailMessage mail = new MailMessage("YOUR EMAIL", "YOUR EMAIL")
                {
                    Subject = "We've created an invoice for your order",
                    Body = GenerateTextInvoice(order)
                };

                client.Send(mail);

                Console.WriteLine("Invoice for order sent over e-mail");
            }
        }
    }
}

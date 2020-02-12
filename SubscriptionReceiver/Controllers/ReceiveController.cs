using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SubscriptionReceiver.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReceiveController : ControllerBase
    {
        [HttpPost]
        public void CompletedOrder([FromBody]CompletedOrder model)
        {
            var secretKey = Request.Headers["Authorization"];

        }
    }

    public class CompletedOrder
    {
        public int? BuyerId { get; set; }
        public string TeamId { get; set; }
        public DateTime OrderDate { get; set; }
        public Address Address { get; set; }
        public CheckoutType CheckoutType { get; set; }
        public string AdditionalInfo { get; set; }
        public int? PaymentId { get; set; }
        public int? CheckoutTypeId { get; set; }
        public decimal? ShippingFee { get; set; }
        public string TrackingNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactEmail { get; set; }
        public string Description { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public string _productName { get; set; }
        public string _pictureUrl { get; set; }
        public decimal _unitPrice { get; set; }
        public decimal _discount { get; set; }
        public int _units { get; set; }
        public string _note { get; set; }
        public string _code { get; set; } = string.Empty;

        private readonly List<OrderItemOption> _options;
    }

    internal class OrderItemOption
    {
        public Guid OptionId { get; set; }
        public string Name { get; set; }
    }

    public class Address
    {
        public string ContryCode { get; private set; }
        public string Country { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
        public string FullAddress { get; private set; }
        public string Home { get; private set; }
    }

    public class CheckoutType
    {
        public DateTime Date { get; set; }
        public int GuestCount { get; set; }
        public string QrInfo { get; set; }
        public string Note { get; set; }
    }
}

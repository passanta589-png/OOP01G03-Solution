using System;
using System.Collections.Generic;
using System.Text;

namespace OOP01G03
{
    internal struct Shipment
    {
        private string _trackingcode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;

        public string TrackingCode
        {
            get { return _trackingcode; }
           private set
           {
                if (string.IsNullOrWhiteSpace(value))
                { _trackingcode = value; }
           }
        }
        public string Description

        {
            get { return _description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                { _description = value; }
            }

        }
        public decimal Weight
        {
            get { return _weight; }
            set

            {
                if (value > 0)
                { _weight = value; }
            }
        }
        public decimal DeliveryFee
        {
            get { return _deliveryFee; }

            private set
            {
                if (value >= 0)
                { _deliveryFee = value; }
            }
            
        }
        public DeliveryAddres destination { get; set; }

        public decimal estimatedcost
        {
            get
            {
                return _weight * 5 + _deliveryFee;
            }
        }
        public Shipment(string trackingcode, string description, decimal weight, decimal deliveryFee, DeliveryAddres destination)
        {
            _trackingcode = trackingcode;
            _description = description;
            _weight = weight;
            _deliveryFee = deliveryFee;
            this.destination = destination;
        }
        public void updateDeliveryFee(decimal newFee)
        {
            if (newFee >= 0)
            {
                _deliveryFee = newFee;
            }
        }
    }
}

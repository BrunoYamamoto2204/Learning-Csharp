﻿using System;
using Aula139_Interface.Entities;

namespace Aula139_Interface.Services
{
    class RentalService
    {
        // Método
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _TaxService;  

        //Construtor
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) { 
            PricePerHour = pricePerHour;  
            PricePerDay = pricePerDay;    
            _TaxService = taxService;
        }

        // Método 
        public void ProcessInvoice(CarRental carRental) {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}

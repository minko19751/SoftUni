﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.fuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        //public void Drive(double distance)
        //{
        //    double remainFuel = FuelQuantity - (distance * FuelConsumption) / 100;

        //    if (remainFuel >= 0)
        //    {
        //        FuelQuantity = remainFuel;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Not enough fuel to perform this trip!");
        //    }
        //}

        //public string WhoAmI()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine($"Make: {this.Make}");
        //    sb.AppendLine($"Model: {this.Model}");
        //    sb.AppendLine($"Year: {this.Year}");
        //    sb.Append($"Fuel: {this.FuelQuantity:F2}L");

        //    return sb.ToString();
        //}
    }
}

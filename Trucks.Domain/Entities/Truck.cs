﻿using Trucks.Domain.Enums;

namespace Trucks.Domain.Entities
{
    public class Truck
    {
        public Truck()
        {
        }

        public Truck(int id, string name, string color, int manufactureYear, int modelYear, TruckModelEnum truckModel)
        {
            Id = id;
            IdTruckModel = (int)truckModel;
            Name = name;
            Color = color;
            ManufactureYear = manufactureYear;
            ModelYear = modelYear;
        }

        public int Id { get; private set; }
        public int IdTruckModel { get; private set; }
        public string? Name { get; private set; }
        public string? Color { get; private set; }
        public int ManufactureYear { get; private set; }
        public int ModelYear { get; private set; }
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; private set; }

        public TruckModel? TruckModel { get; private set; }

        public void SetUpdatedDate()
        {
            UpdatedDate = DateTime.Now;
        }

        public bool IsValid()
        {
            var currentYear = DateTime.Now.Year;

            if (Enum.IsDefined(typeof(TruckModelEnum), IdTruckModel) && ManufactureYear == currentYear && (ModelYear == currentYear || ModelYear == currentYear + 1))
                return true;
            else
                return false;
        }
    }
}
﻿using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Entities.Types
{
    public class Dog : Animal, IAnimal
    {
        public Dog(string name, int energy, int happines, int procedureTime)
            : base(name, energy, happines, procedureTime)
        {
        }

        public override string ToString()
        {
            return $"    Animal type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}";
        }
    }
}
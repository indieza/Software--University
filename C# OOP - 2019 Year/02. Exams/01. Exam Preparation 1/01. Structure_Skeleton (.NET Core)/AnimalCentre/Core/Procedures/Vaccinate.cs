﻿using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Core
{
    public class Vaccinate : Procedure, IProcedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            throw new NotImplementedException();
        }

        public override string History()
        {
            throw new NotImplementedException();
        }
    }
}
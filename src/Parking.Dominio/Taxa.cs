using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Taxa : IValueObject
    {
        public decimal TaxaReferencia { get; private set; } = 2;


    }
}

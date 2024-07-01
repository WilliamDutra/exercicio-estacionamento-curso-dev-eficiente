using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Periodo : IValueObject
    {
        public DateTime HorarioEntrada { get; private set; }

        public DateTime? HorarioSaida { get; private set; }

        public Periodo(DateTime entrada)
        {
            HorarioEntrada = entrada;
        }

        public void Sair()
        {
            HorarioSaida = DateTime.Now;
        }

    }
}

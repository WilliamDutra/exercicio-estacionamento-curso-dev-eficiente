using System;

namespace Parking.Dominio
{
    public class Taxa
    {
        public decimal Calcular(DateTime entrada, DateTime saida)
        {
            var horas = Math.Abs(entrada.Subtract(saida).Hours);
            decimal taxa = 0;

            if (horas <= 1)
                taxa = horas * 3.5M;

            if (horas > 1 && horas <= 3)
                taxa = horas * 4.0M;

            if (horas > 4)
                taxa = horas * 2.5M;

            return Math.Abs(taxa);

        }
    }
}

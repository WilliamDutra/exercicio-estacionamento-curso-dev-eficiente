using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Andar
    {
        public string Numero { get; private set; }

        private Andar(string numero)
        {
            Numero = numero;
        }

        public static Andar Criar(string numero)
        {
            return new Andar(numero);
        }

        public static Andar Restaurar(string numero)
        {
            return new Andar(numero);
        }

    }
}

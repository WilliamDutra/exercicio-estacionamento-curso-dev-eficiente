using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Andar : Entidade
    {
        public string Numero { get; private set; }

        private Andar(Guid codigo, string numero)
        {
            Codigo = codigo;
            Numero = numero;
        }

        public static Andar Criar(string numero)
        {
            return new Andar(Guid.NewGuid(), numero);
        }

        public static Andar Restaurar(Guid codigo, string numero)
        {
            return new Andar(codigo, numero);
        }

    }
}

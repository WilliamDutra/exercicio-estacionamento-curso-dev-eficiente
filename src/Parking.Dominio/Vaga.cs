using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Vaga : Entidade
    {
        public Andar Andar { get; private set; }

        public bool EstaOcupada { get; private set; }

        private Vaga(Guid codigo, Andar andar, bool estaOcupada)
        {
            Codigo = codigo;
            Andar = andar;
            EstaOcupada = estaOcupada;
        }

        public static Vaga Criar(Andar andar)
        {
            return new Vaga(Guid.NewGuid(), andar, false);
        }

        public static Vaga Restaurar(Guid codigo, Andar andar, bool estaOcupada)
        {
            return new Vaga(codigo, andar, estaOcupada);
        }

    }
}

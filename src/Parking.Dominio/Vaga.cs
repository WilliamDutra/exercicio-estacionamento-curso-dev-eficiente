using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Vaga : Entidade
    {
        public Andar Andar { get; private set; }

        public bool EstaOcupada { get; private set; }

        public ETipoVaga TipoVaga { get; private set; }

        private Vaga(Guid codigo, Andar andar, ETipoVaga tipoVaga, bool estaOcupada)
        {
            Codigo = codigo;
            Andar = andar;
            EstaOcupada = estaOcupada;
        }

        public static Vaga Criar(Andar andar, ETipoVaga tipoVaga)
        {
            return new Vaga(Guid.NewGuid(), andar, tipoVaga, false);
        }

        public static Vaga Restaurar(Guid codigo, Andar andar, ETipoVaga tipoVaga, bool estaOcupada)
        {
            return new Vaga(codigo, andar, tipoVaga, estaOcupada);
        }

    }
}

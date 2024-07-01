using System;
using Parking.Shared;
using System.Collections.Generic;

namespace Parking.Dominio
{
    public class Estacionamento : Entidade
    {
        public IReadOnlyCollection<Vaga> Vagas => _Vagas;

        private List<Vaga> _Vagas;

        public int TotalVagas { get; private set; }

        private Estacionamento(Guid codigo, List<Vaga> vagas, int totalVagas)
        {
            Codigo = codigo;
            _Vagas = vagas;
            TotalVagas = totalVagas;
        }

        public static Estacionamento Criar(int totalVagas)
        {
            return new Estacionamento(Guid.NewGuid(), new List<Vaga>(), totalVagas);
        }

        public static Estacionamento Restaurar(Guid codigo, List <Vaga> vagas, int totalVagas)
        {
            return new Estacionamento(codigo, vagas, totalVagas);
        }

        public void AdicionarVaga(string andar, ETipoVaga tipoVaga = ETipoVaga.Normal)
        {
            if (TotalVagas <= 0)
                throw new VagaException("Não há mais vagas disponiveis nesse andar!");
            var novoAndar = Andar.Criar(andar);
            var vaga = Vaga.Criar(novoAndar, tipoVaga);
            _Vagas.Add(vaga);
            TotalVagas = TotalVagas - 1;
        }

    }
}

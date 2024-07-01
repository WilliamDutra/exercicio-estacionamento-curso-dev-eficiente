using System;
using System.Collections.Generic;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Estacionamento : Entidade
    {
        public IReadOnlyCollection<Vaga> Vagas => _Vagas;

        private List<Vaga> _Vagas = new List<Vaga>();

    }
}

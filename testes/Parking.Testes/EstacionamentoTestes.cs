using Parking.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Testes
{
    public class EstacionamentoTestes
    {
        [Fact(DisplayName = "Deve criar um estacionamento")]
        public void Deve_criar_um_estacionamento()
        {
            var estacionamento = Estacionamento.Criar(10);
            Assert.Equal(estacionamento.TotalVagas, 10);
        }

    }
}

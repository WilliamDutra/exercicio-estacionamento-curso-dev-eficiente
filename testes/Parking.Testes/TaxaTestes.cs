using Parking.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Testes
{
    public class TaxaTestes
    {
        [Fact(DisplayName = "Calcular a taxa quando o periodo for de até 1 hora")]
        public void Calcular_taxa_quando_taxa_ate_uma_hora()
        {
            var periodo = new Periodo(DateTime.Now.AddHours(-1));
            var vaga = Vaga.Criar(Andar.Criar("1° andar"), ETipoVaga.Normal);
            var ticket = Ticket.Criar(vaga, periodo);
            var resultado = ticket.PagarComCredito();
            Assert.Equal(resultado, 3.5M);
        }


        [Fact(DisplayName = "Calcular a taxa quando o periodo for até 3 horas")]
        public void Calcular_taxa_quando_taxa_ate_uma_3()
        {
            var periodo = new Periodo(DateTime.Now.AddHours(-3));
            var vaga = Vaga.Criar(Andar.Criar("1° andar"), ETipoVaga.Normal);
            var ticket = Ticket.Criar(vaga, periodo);
            var resultado = ticket.PagarComCredito();
            Assert.Equal(resultado, 12.0M);
        }
    }
}

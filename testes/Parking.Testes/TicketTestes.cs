using Parking.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking.Testes
{
    public class TicketTestes
    {
        [Fact(DisplayName = "Deve criar um novo ticket")]
        public void Deve_criar_um_novo_ticket()
        {
            var periodo = new Periodo(DateTime.Parse("2024-07-01 12:00"));
            var vaga = Vaga.Criar(Andar.Criar("1° andar"), ETipoVaga.Normal);
            var ticket = Ticket.Criar(vaga, periodo);
        }

        [Fact(DisplayName = "Deve pagar um ticket com dinheiro")]
        public void Deve_pagar_um_ticket_com_dinheiro()
        {
            var periodo = new Periodo(DateTime.Parse("2024-07-01 12:00"));
            var vaga = Vaga.Criar(Andar.Criar("1° andar"), ETipoVaga.Normal);
            var ticket = Ticket.Criar(vaga, periodo);
            ticket.PagarComDebito();
        }
    }
}

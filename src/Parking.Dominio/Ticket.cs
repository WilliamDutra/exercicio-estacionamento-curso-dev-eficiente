using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Ticket : Entidade
    {
        public ETipoPagamento TipoPagamento { get; private set; }

        public Vaga Vaga { get; private set; }

        public Periodo Periodo { get; private set; }

        public Taxa Taxa { get; private set; }

        public Ticket(Guid codigo, Vaga vaga, Periodo periodo, Taxa taxa)
        {
            Codigo = Codigo;
            Vaga = vaga;
            Periodo = periodo;
            Taxa = taxa;
        }

        public static Ticket Criar(Vaga vaga, Periodo periodo)
        {
            var taxa = new Taxa();
            return new Ticket(Guid.NewGuid(), vaga, periodo, taxa);
        }

        public static Ticket Restaurar(Guid codigo, Vaga vaga, Periodo periodo, Taxa taxa)
        {
            return new Ticket(codigo, vaga, periodo, taxa);
        }

        public void PagarComCredito()
        {
            TipoPagamento = ETipoPagamento.Credito;
        }

        public void PagarComDebito()
        {
            TipoPagamento = ETipoPagamento.Debito;
        }

        public void PagarComPix()
        {
            TipoPagamento = ETipoPagamento.Pix;
        }


    }
}

using System;
using Parking.Shared;

namespace Parking.Dominio
{
    public class Ticket : Entidade
    {
        public ETipoPagamento TipoPagamento { get; private set; }

        public Vaga Vaga { get; private set; }

        public Periodo Periodo { get; private set; }

        public Ticket(Guid codigo, Vaga vaga, Periodo periodo)
        {
            Codigo = codigo;
            Vaga = vaga;
            Periodo = periodo;
        }

        public static Ticket Criar(Vaga vaga, Periodo periodo)
        {
            return new Ticket(Guid.NewGuid(), vaga, periodo);
        }

        public static Ticket Restaurar(Guid codigo, Vaga vaga, Periodo periodo)
        {
            return new Ticket(codigo, vaga, periodo);
        }

        public decimal PagarComCredito()
        {
            TipoPagamento = ETipoPagamento.Credito;
            Periodo.Sair();
            var taxa = new Taxa();
            var resultado = taxa.Calcular(Periodo.HorarioEntrada, Periodo.HorarioSaida.Value);
            return resultado;
        }

        public decimal PagarComDebito()
        {
            TipoPagamento = ETipoPagamento.Debito;
            Periodo.Sair();
            var taxa = new Taxa();
            var resultado = taxa.Calcular(Periodo.HorarioEntrada, Periodo.HorarioSaida.Value);
            return resultado;
        }

        public decimal PagarComPix()
        {
            TipoPagamento = ETipoPagamento.Pix;
            Periodo.Sair();
            var taxa = new Taxa();
            var resultado = taxa.Calcular(Periodo.HorarioEntrada, Periodo.HorarioSaida.Value);
            return resultado;
        }


    }
}

using Parking.Dominio;

namespace Parking.Testes
{
    public class VagaTestes
    {
        [Fact(DisplayName = "Deve criar uma vaga")]
        public void Deve_cria_uma_vaga()
        {
            var primeiroAndar = Andar.Criar("1° andar");
            var vaga = Vaga.Criar(primeiroAndar, ETipoVaga.Normal);
            Assert.Equal(vaga.EstaOcupada, false);
            Assert.NotNull(vaga.Codigo);
        }

        [Fact(DisplayName = "Não deve deixar criar vagas acima da capacidade do estacionamento")]
        public void Nao_deve_deixar_criar_vagas_acima_da_capacidade_do_estacionamento()
        {
            var estacionamento = Estacionamento.Criar(10);

            Assert.Throws<VagaException>(() =>
            {
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
                estacionamento.AdicionarVaga("1° andar");
            });
        }

    }
}
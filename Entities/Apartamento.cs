namespace Mentoria_GFT.Entities
{
    public class Apartamento : Imovel
    {

        public Apartamento(string Endereco, string Cidade, int Metragem, byte qtdQuartos, byte qtdBanheiros,int valorImovel, byte Andar, string numeroApartamento, string Torre) : base(Endereco, Cidade, Metragem, qtdQuartos, qtdBanheiros,valorImovel)
        {
            this.Andar = Andar;
            this.NumeroApartamento = numeroApartamento;
            this.Torre = Torre;
        }

        public byte Andar { get; set; }
        public string NumeroApartamento { get; set; }
        public string Torre { get; set; }
        public override double TaxaCorretor()
        {
            return ValorImovel * 1.2;
        }

        public override string ToString()
        {
            return "Cidade: " + Cidade + "\n"
                + "Endereço: " + Endereco + "\n"
                + "Metragem: " + Metragem + "Mt" + "\n"
                + "Quantidade de Quartos: " + QtdQuartos + "\n"
                + "Andar: " + Andar + "\n"
                + "Número do Apartamento: " + NumeroApartamento + "\n"
                + "Torre: " + Torre + "\n"
                + "Valor do Imovel: R$" + ValorImovel  + "\n"
                + "Valor com a Taxa: " + TaxaCorretor();
        }

    }
 
 
}
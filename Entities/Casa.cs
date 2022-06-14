namespace Mentoria_GFT.Entities
{
    public class Casa : Imovel
    {
        public Casa(string Endereco, string Cidade, int Metragem, byte qtdQuartos,byte qtdBanheiros,int valorImovel, int tamanhoQuintal) : base(Endereco, Cidade, Metragem, qtdQuartos, qtdBanheiros, valorImovel)
        {
            this.TamanhoQuintal = tamanhoQuintal;
        }
        public int TamanhoQuintal { get; set; }

        public override double TaxaCorretor()
        {
            return ValorImovel * 1.1;
        }
        public override string ToString()
        {
            return "Cidade: " + Cidade + "\n"
              + "Endereço: " + Endereco + "\n"
              + "Metragem: " + Metragem + "Mt" + "\n"
              + "Quantidade de Quartos: " + QtdQuartos + "\n"
              + "Valor do Imovel: R$" + ValorImovel + "\n"
              + "Valor com a Taxa: " + TaxaCorretor() + "\n"
              + "Tamanho do quintal: " + TamanhoQuintal + "Mt";
        }
    }
}
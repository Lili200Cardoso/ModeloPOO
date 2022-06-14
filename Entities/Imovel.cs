namespace Mentoria_GFT.Entities
{
    public class Imovel
    {
       public string Endereco { get; set; }
       public string  Cidade { get; set; }
       public int Metragem { get; set; }
       public byte QtdQuartos { get; set; }
       public byte QtdBanheiros { get; set; }
       public int  ValorImovel {get; set;}

        public virtual double TaxaCorretor()
        {
            return ValorImovel * 1.1;
        }
       
       public Imovel(string Endereco, string Cidade, int Metragem, byte qtdQuartos,byte qtdBanheiros, int valorImovel)
       {
           this.Endereco = Endereco;
           this.Cidade = Cidade;
           this.Metragem = Metragem;
           this.QtdQuartos = qtdQuartos;
           this.QtdBanheiros = qtdBanheiros;
           this.ValorImovel = valorImovel;
       }
    }
}
using System;
namespace projCliente
{
    public class ClienteJuridico : Cliente
    {
        public string CNPJ { set; get; }

        public override void dizQuemSouMesmo()
        {
            Console.WriteLine("EU SOU CLIENTE JURIDICO E ACABOU-SE");
        }

        public ClienteJuridico(string nome, string endereco, Bairro bairro, string cnpj)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.CNPJ = cnpj;
        }

        public ClienteJuridico()
        {
        }
    }
}
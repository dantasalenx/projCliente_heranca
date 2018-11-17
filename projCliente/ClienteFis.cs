using System;
namespace projCliente
{
    public class ClienteFisico : Cliente
    {
        public string CPF { set; get; }


        public override void dizQuemSouMesmo()
        {
            Console.WriteLine("EU SOU CLIENTE FISICO E ACABOU-SE");
        }

        public ClienteFisico(string nome, string endereco, Bairro bairro, string cpf)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.CPF = cpf;
        }

        public ClienteFisico()
        {
        }
    }
}
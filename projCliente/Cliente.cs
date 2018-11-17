using System;
namespace projCliente
{
    public class Cliente
    {
        public string Nome { set; get; }
        public string Endereco { set; get; }
        public Bairro Bairro { set; get; }

        public virtual void dizQuemSouMesmo()
        {
            Console.WriteLine("No fim de tudo, sou apenas CLIENTE!");
        }

        public Cliente()
        {

        }
    }
}
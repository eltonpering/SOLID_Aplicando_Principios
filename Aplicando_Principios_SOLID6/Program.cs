using System;

namespace Aplicando_Principios_SOLID6
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descontoFidelidade =   new CalculaDescontoFidelidade();

            ICalculaDescontoStatusContaFactory descontoConta =   new CalculaDescontoStatusContaFactory();

            GerenciadorDeDescontos gerarDesconto = new GerenciadorDeDescontos(descontoFidelidade, descontoConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado1 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado1}");

            var resultado2 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado2}");

            var resultado3 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 10);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado3}");

            Console.WriteLine("\n\nValor da compra 1000 e fidelidade 4 anos (4%)\n");

            var resultado4 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteComum}, valor do desconto é de : {resultado4}");

            var resultado5 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteEspecial}, valor do desconto é de : {resultado5}");

            var resultado6 =
                gerarDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVIP, 4);
            Console.WriteLine($"Cliente {StatusContaCliente.ClienteVIP}, valor do desconto é de : {resultado6}");

            Console.ReadLine();
        }
    }
}

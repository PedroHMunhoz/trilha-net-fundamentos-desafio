namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Implementado e adicionadas algumas validações para robustecer o código 22/08/2024
            string placaDigitada = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placaDigitada))
            {
                if (!veiculos.Any(x => x.ToUpper() == placaDigitada.ToUpper()))
                {
                    // ToUpper para garantir que as letras sejam sempre maiúsculas, independente do input do usuário
                    veiculos.Add(placaDigitada.ToUpper());
                }
                else{
                    Console.WriteLine("Este veículo já está estacionado aqui. Confira se digitou a placa corretamente!");
                }
            }
            else
            {
                Console.WriteLine("O campo de placa deve ser preenchido para estacionar o veículo. Por favor, informe a placa!");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Implementado e adicionadas algumas validações para robustecer o código 22/08/2024

            // ToUpper para garantir que as letras sejam sempre maiúsculas, independente do input do usuário
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = Convert.ToInt32(Console.ReadLine());

                if (horas <= 0)
                {
                    Console.WriteLine("O valor digitado para as horas é inválido. Digite um valor maior que zero!");
                }
                else
                {
                    decimal valorTotal = this.precoInicial + (this.precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente!");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // Implementado 22/08/2024
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

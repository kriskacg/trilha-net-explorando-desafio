using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           bool sucesso = hospedes.Count <= Suite.Capacidade;
            if (sucesso)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException($"O número de hóspedes ({hospedes.Count}) é superior a capacidade da suite ({Suite.Capacidade}).");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            
            decimal valor = 0M;
            valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor = (DiasReservados * Suite.ValorDiaria) * 0.90M;
            }

            return valor;
        }

        public void ListaHospedes()
        {
            Console.WriteLine($"Hóspedes:");

            for (int count = 0; count < Hospedes.Count; count++)
            {
                string texto = $"Nº {count + 1} - {Hospedes[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}
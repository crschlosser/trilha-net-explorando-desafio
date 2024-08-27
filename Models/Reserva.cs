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
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            int numeroHospedes=hospedes.Count;
            int capacidadeSuite=Suite.Capacidade;

            Console.WriteLine("LISTA DAS RESERVAS SOLICITADAS ===================================");
            Console.WriteLine($"Tipo de Suite: {Suite.TipoSuite} - Qtde Hospedes: {numeroHospedes} - Dias Reservados: {DiasReservados}");
            Console.WriteLine("==================================================================");
            Console.WriteLine("   ");

            if (numeroHospedes<=capacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                Console.WriteLine("   ");
                Console.WriteLine("********************************************************************");
                Console.WriteLine("  ERRO AO FAZER RESERVA");
                Console.WriteLine("********************************************************************");
                Console.WriteLine($"A quantidade de hospedes excedeu a capacidade da suite em "+(numeroHospedes-capacidadeSuite)+" hospedes");
                Console.WriteLine("********************************************************************");
                throw new ArgumentException("O número de hospedes excedem a capacidade da suite");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return (Hospedes.Count);
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            decimal valorAPagar=Suite.ValorDiaria*DiasReservados;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (valorAPagar>100)
            {
                valorAPagar=valorAPagar-valorAPagar*10/100;
            }
            valor=valorAPagar;
            return valor;
        }
    }
}
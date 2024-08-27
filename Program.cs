using System.Text;
using DesafioProjetoHospedagem.Models;

Console.Clear();

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(new Pessoa(nome: "Hóspede 3"));
hospedes.Add(new Pessoa(nome: "Hóspede 4"));

Console.WriteLine("LISTA DOS HOSPEDES QUE QUEREM SE HOSPEDAR");

foreach(var item in hospedes)
{

    Console.WriteLine(item.Nome);

}
Console.WriteLine("=========================================");
Console.WriteLine("   ");

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 30);

Console.WriteLine("LISTA DE SUITES DISPONIVEIS ======================================");
Console.WriteLine($"Tipo de Suite: {suite.TipoSuite} - Capacidade: {suite.Capacidade} - Valor da Diária: {suite.ValorDiaria.ToString("C")}");
Console.WriteLine("==================================================================");
Console.WriteLine("   ");

// Cria uma nova reserva, passando a suíte e os hóspedes

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;
  
        Console.OutputEncoding = Encoding.UTF8;

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2"),
            //new Pessoa(nome: "Hóspede 3")
        };

        // Cria a suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 10);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new Reserva(diasReservados: 12);
        reserva.CadastrarSuite(suite);

        try
        {
            reserva.CadastrarHospedes(hospedes);
            // Exibe a quantidade de hóspedes e o valor da diária
            Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
        catch (CapacidadeInsuficienteException ex)
        {
            Console.WriteLine(ex.Message);
        }
    

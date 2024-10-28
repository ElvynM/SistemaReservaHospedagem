using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models;
public class CapacidadeInsuficienteException : Exception
{
    public CapacidadeInsuficienteException(int capacidade, int quantidadeHospedes)
        : base($"Capacidade insuficiente: a suíte suporta {capacidade} hóspedes, mas foram fornecidos {quantidadeHospedes}.")
    {
        
    }
}

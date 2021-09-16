using System.ComponentModel.DataAnnotations;

namespace Senai.Rental.WebApi.Domains
{
    public class VeiculoDomain
    {
        public int idVeiculo { get; set; }
        public EmpresaDomain empresa { get; set; }
        [Required(ErrorMessage = "Todo carro tem um cor")]
        public string cor { get; set; }
        public string placa { get; set; }
    }
}

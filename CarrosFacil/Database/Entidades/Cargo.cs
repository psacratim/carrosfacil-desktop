using System;
using System.Data;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int Status { get; set; }

        public Cargo()
        {
            this.Id = 0;
            this.DataCadastro = DateTime.Now;
            this.Status = 1;
        }
    }
}

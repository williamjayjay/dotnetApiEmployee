using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SegundaAPI.Domain.Model.CompanyAggregate
{
    [Table("company")]
    public class Company
    {
        [Key]
        public int ID { get;  set; }
        public string Nome { get;  set; }
    }
}

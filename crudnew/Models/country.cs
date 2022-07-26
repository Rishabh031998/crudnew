using System.ComponentModel.DataAnnotations.Schema;

namespace crudnew.Models
{
    [Table("country")]
    public class country
    {
        
        public int CountryId { get; set; }
        public string countryName { get; set; }
        public int stateId { get; set; }
    }
}

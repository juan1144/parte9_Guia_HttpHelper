using System.ComponentModel.DataAnnotations;
namespace parte9_Guia_HttpHelper.Models
{
    public class marcas
    {
        [Key]
        public int id_marca { get; set; }
        public string? nombre_marca { get; set; }
        public char? estados { get; set; }

    }
}

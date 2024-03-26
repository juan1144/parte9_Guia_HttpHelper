using System.ComponentModel.DataAnnotations;
namespace parte9_Guia_HttpHelper.Models
{
    public class marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int id_marca { get; set; }
        [Display(Name = "Nombre de la marca")]
        public string? nombre_marca { get; set; }
        [Display(Name = "Estado de la marca")]
        public char? estados { get; set; }

    }
}

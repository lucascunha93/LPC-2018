using System.ComponentModel.DataAnnotations;

namespace AppAssociados.Domain
{
    public class EstadoCivil
    {
        public int id { get; set; }

        [Required(ErrorMessage="Descrição obrigatória!", AllowEmptyStrings=false)]
        [StringLength(20, MinimumLength=5, ErrorMessage="Descrição deve ter no mínimo 5 caracteres e no máximo 20 caracteres!")]
        public string descricao { get; set; }
    }
}
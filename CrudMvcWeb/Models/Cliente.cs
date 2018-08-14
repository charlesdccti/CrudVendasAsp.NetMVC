using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrudMvcWeb.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [Column("clienteID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int clienteID { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Favor informar o nome do cliente.")]
        public string nome { get; set; }

        [StringLength(14)]
        [Required(ErrorMessage = "Favor informar o CPF.")]
        public string cpf_cnpj { get; set; }

        //public string endereco { get; set; }

        //public string bairro { get; set; }

        //public string cidade { get; set; }

        //public string cep { get; set; }

        //public string email { get; set; }

        //public string telefone { get; set; }

        //public string status_cliente { get; set; }

        //public DateTime data_cadastro { get; set; }
    }
}
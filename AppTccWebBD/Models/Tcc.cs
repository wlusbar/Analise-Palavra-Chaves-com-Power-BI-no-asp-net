using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppTccWebBD.Models
{
    [Table("RepositorioTccExcel")]
    public class Tcc
    {
        [Key]
        public int AlunoId{ get; set; }
        [Required]
        public string Aluno { get; set; }
        //[Required]
        public string OrientatadorTcc { get; set; }
        //[Required]
        public string AvaliadorApresentacao { get; set; }
        //[Required]
        public string Titulo { get; set; }
        //[Required]
        public string Resumo { get; set; }
        [Required]
        public int Semestre { get; set; }
        [Required]
        public int Ano { get; set; }
        [Required]
        public Boolean Mencao { get; set; }
        [Required]
        public string Chave1 { get; set; }
        [Required]
        public string Chave2 { get; set; }
        [Required]
        public string Chave3 { get; set; }
        [Required]
        public string Chave4 { get; set; }
        [Required]
        public string Chave5 { get; set; }
        
    }
}

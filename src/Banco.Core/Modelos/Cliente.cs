using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Banco.Domain.Enums;

namespace Banco.Domain.Modelos
{
    public class Cliente
    {
        public long CPFCNPJ { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "tinyint")]
        public EnumTipoPessoa TipoPessoa { get; set; }
        public string Nacionalidade { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string UFNascimento { get; set; }
        public char Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string NomeConjuge { get; set; }
        public string Profissao { get; set; }
        [Column(TypeName = "varchar(10)")]
        public EnumTipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateOnly DataEmissaoDoc { get; set; }
        public string OrgaoEmissor { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string DDD { get; set; }
    }
}

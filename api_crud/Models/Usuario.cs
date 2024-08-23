using System.ComponentModel.DataAnnotations;

namespace api_crud.Models
{
	public class Usuario
	{
        [Key]
		public string Email { get; set; }
		public string Nome { get; set; }
        public string Senha { get; set; }
        public string CodigoPessoa { get; set; }
        public string LembreteSenha { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}

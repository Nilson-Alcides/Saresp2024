namespace AppSaresp_2024.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Serie { get; set; }
        public string Turma { get; set; }
        public DateTime DaNasc { get; set; }
    }
}

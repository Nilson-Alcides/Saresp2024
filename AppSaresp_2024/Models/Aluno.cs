namespace AppSaresp_2024.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public Stream Nome { get; set; }
        public Stream Email { get; set; }
        public Stream Telefone { get; set; }
        public Stream Serie { get; set; }
        public Stream Turma { get; set; }
        public DateTime DaNasc { get; set; }
    }
}

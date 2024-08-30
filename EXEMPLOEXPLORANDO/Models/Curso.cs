namespace EXEMPLOEXPLORANDO.Models
{
    public class Curso
    {
        public string Nome { get; set; } = string.Empty;
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            return true;
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void ListarAlunos()
        {
            Console.WriteLine("Alunos do Curso de inglês");

            for(int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }


            //foreach (Pessoa aluno in Alunos)
            //{
                //Console.WriteLine(aluno.NomeCompleto);
            //}
        }
    }
}
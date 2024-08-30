namespace EXEMPLOEXPLORANDO.Models
{
    public class Pessoa
    {
        private string _nome = string.Empty;
        private int _idade;

        public Pessoa()
        {

        }        
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; } = string.Empty;
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {

            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade: {Idade}");
        }
    }
}
using EXEMPLOEXPLORANDO.Models;

Pessoa p1 = new Pessoa(nome: "Fabio", sobrenome: "De Souza Néu");

Pessoa p2 = new Pessoa(nome: "Miguel", sobrenome: "Meireles Néu");

Curso cursoDeingles = new Curso();

cursoDeingles.Nome = "Ingles";
cursoDeingles.Alunos =  new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();



// using EXEMPLOEXPLORANDO.Models;

// Pessoa p1 = new Pessoa();

// p1.Nome = "Fabio";
// p1.Sobrenome = "De Souza Néu";
// p1.Idade = 41;

// p1.Apresentar();

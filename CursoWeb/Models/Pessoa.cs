using CursoWeb.Interfaces;

namespace CursoWeb.Models
{
    public class Pessoa : IPessoa
    {
        //PROP TAB 2
        #region Padrao Singleton
        private static Pessoa _Pessoa = null;
        public Pessoa() { }
        public static Pessoa GetInstancia()
        {
            if (_Pessoa==null)
                _Pessoa = new Pessoa();
            return _Pessoa;
        }
        #endregion
        #region Peossoa
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int AnoNascimento { get; set; }
        public double Altura { get; set; }

        List<Pessoa> p = new List<Pessoa>();

        public List<Pessoa> GetPessoa()
        {
            return p;
        }

        public string Adicionar(Pessoa pessoa)
        {
            p.Add(pessoa);
            return $"{pessoa.Nome} adicionada com sucesso";
        }

        #endregion
    }
}

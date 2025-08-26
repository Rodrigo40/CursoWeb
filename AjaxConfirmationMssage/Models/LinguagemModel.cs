using System.Collections.ObjectModel;

namespace AjaxConfirmationMssage.Models
{
    public class LinguagemModel
    {
        #region Padrao Singleton
        private static LinguagemModel _LinguagemModel = null;
        public LinguagemModel() { }
        public static LinguagemModel Instancia
        {
            get
            {
                if (_LinguagemModel == null)
                    _LinguagemModel = new LinguagemModel();
                return _LinguagemModel;
            }
        }

        #endregion
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Tipagem { get; set; }
        public string DataCricao { get; set; }
        public List<LinguagemModel> lista = new List<LinguagemModel>();
    }
}


namespace ProjetoAula03.Entities
{
    public class Profissional : Pessoa
    {
        #region Atributos
        private string? _numRegistro;
        private decimal? _salario;
        private Empresa? _empresa;

        #endregion

        #region Propriedades

        public string? NumRegistro
        { get => _numRegistro; set => _numRegistro = value; }
        public decimal? Salario
        { get => _salario; set => _salario = value; }
        public Empresa? Empresa
        { get => _empresa; set => _empresa = value; }

        #endregion
    }
}

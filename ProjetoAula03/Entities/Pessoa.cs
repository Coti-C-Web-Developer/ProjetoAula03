namespace ProjetoAula03.Entities
{
    public class Pessoa
    {
        #region Atributos

        private Guid? _id;
        private string? _nome;
        private string? _cpf;

        #endregion

        #region Propriedades

        public Guid? Id { get => _id; set => _id = value; }
        public string? Nome
        { get => _nome; set => _nome = value; }
        public string? Cpf
        { get => _cpf; set => _cpf = value; }

        #endregion
    }
}

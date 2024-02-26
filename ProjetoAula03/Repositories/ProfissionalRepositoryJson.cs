using Newtonsoft.Json;
using ProjetoAula03.Entities;

namespace ProjetoAula03.Repositories
{
    public class ProfissionalRepositoryJson : ProfissionalRepository
    {
        public override void Exportar(Profissional profissional)
        {
            //serializando os dados do profissional para formato JSON
            var json = JsonConvert.SerializeObject(profissional, Formatting.Indented);

            //gravar em arquivo
            var streamWriter = new StreamWriter("c:\\temp\\profissional.json");
            streamWriter.WriteLine(json);
            streamWriter.Close();
        }
    }
}

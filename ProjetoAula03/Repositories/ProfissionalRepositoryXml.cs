using ProjetoAula03.Entities;
using System.Xml.Serialization;

namespace ProjetoAula03.Repositories
{
    public class ProfissionalRepositoryXml : ProfissionalRepository
    {
        public override void Exportar(Profissional profissional)
        {
            //serializando os dados da classe Profissional para XML
            var xmlSerializer = new XmlSerializer(typeof(Profissional));

            //escrevendo os dados em um arquivo
            var streamWriter = new StreamWriter("c:\\temp\\profissional.xml");
            xmlSerializer.Serialize(streamWriter, profissional);
            streamWriter.Close();
        }
    }
}

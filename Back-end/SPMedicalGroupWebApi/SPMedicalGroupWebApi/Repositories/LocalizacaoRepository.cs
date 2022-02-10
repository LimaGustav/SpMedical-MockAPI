using MongoDB.Driver;
using SPMedicalGroupWebApi.Domains;
using SPMedicalGroupWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMedicalGroupWebApi.Repositories
{
    public class LocalizacaoRepository : ILocalizacaoRepository
    {

        private readonly IMongoCollection<Localizacao> _localizacao;

        public LocalizacaoRepository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("sp_lima");
            _localizacao = database.GetCollection<Localizacao>("mapas");
        }

        public bool Cadastrar(Localizacao novaLocalizacao)
        {
            _localizacao.InsertOne(novaLocalizacao);
            return true;
        }

        public List<Localizacao> ListarTodas()
        {
            return _localizacao.Find(localizacao => true).ToList();
        }
    }
}

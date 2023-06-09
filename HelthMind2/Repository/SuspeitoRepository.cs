﻿using SystemIdwallApi.Context;

namespace SystemIdwallApi.Model
{
    public class SuspeitoRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public SuspeitoRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;


        }
        public IList<SuspeitosModel> ListarTodos()
        
        {
            var Lista = new List<SuspeitosModel>();
            Lista = dataBaseContext.Suspeito.ToList<SuspeitosModel>();
            return Lista;

        }

        // Inserir registro de suspeito
        public void Inserir(SuspeitosModel suspeitosModel)
        {
            dataBaseContext.Suspeito.Add(suspeitosModel);
            dataBaseContext.SaveChanges();
        }

        // Consultar suspeito pelo nome
        public SuspeitosModel ConsultarPorNome(string nomePesquisa)
        {
            var suspeito = dataBaseContext.Suspeito.Where(r => r.NomeSuspeito.Contains(nomePesquisa)).FirstOrDefault<SuspeitosModel>();

            return suspeito;
        }

        // Pesquisr por classificação de Suspeito - Red | Yellow | Un
        public SuspeitosModel ConsultarPorClassificação(string classificacaoPesquisa)
        {
            var suspeito = dataBaseContext.Suspeito.Where(r => r.Classificacao == classificacaoPesquisa).FirstOrDefault<SuspeitosModel>();
            return suspeito;
        }

        //public IList<SuspeitosModel> ListarPorNacionalidade(string nacionalidadePesquisa)
       // {
         //   var lista = new List<SuspeitosModel>();
          //  lista = dataBaseContext.Suspeito.Where(r => r.NacionalidadeId == /nacionalidadePesquisa).FirstOrDefault<SuspeitosModel>();

           // return lista;
       // }
    }
}

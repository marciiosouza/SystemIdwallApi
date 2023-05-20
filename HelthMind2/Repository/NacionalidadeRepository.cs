using SystemIdwallApi.Context;
using SystemIdwallApi.Model;

namespace SystemIdwallApi.Repository
{
    public class NacionalidadeRepository
    {
        private readonly DataBaseContext dataBaseContext;

        public NacionalidadeRepository(DataBaseContext dataBaseContext)
        {
            this.dataBaseContext = dataBaseContext;

        }

        public void InserirNacionalidade(NacionalidadeModel nacionalidadeModel)
        {
            dataBaseContext.Nacionalidade.Add(nacionalidadeModel);
            dataBaseContext.SaveChanges();
        }
    }
}

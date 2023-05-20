
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemIdwallApi.Model
{
    [Table("TB_NACIONALIDADE")]
    public class NacionalidadeModel
    {

        [Key]
        [Column("NACIONALIDADEID")]
        public string NacionalidadeId { get; set; }

        [Column("NACIONALIDADEDESC")]
        public string NacionalidadeDesc { get; set; }

        //public virtual SuspeitosModel SuspeitosModel { get; set; }

        public NacionalidadeModel(string nacionalidadeId, string nacionalidadeDesc)
        {
            NacionalidadeId = nacionalidadeId;
            NacionalidadeDesc = nacionalidadeDesc;
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.Models
{
    public class m_dukcapil_data
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid m_dukcapil_data_id { get; set; }

        public string nik { get; set; }

        public string name { get; set; }

        public string maiden_name { get; set; }

        public DateTime birth_date { get; set; }

        public string gender { get; set; }

        [ForeignKey("religion_id")]
        public m_religion religion { get; set;}
        public Guid religion_id { get; set; }

        [ForeignKey("marital_status")]
        public m_marital_status marital { get; set;}
        public Guid marital_status { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.Models
{
    public class m_religion
    {
        [Key]
        public Guid religion_id { get; set; }

        public string religion_name { get; set; }

        public string usr_crt { get; set; }

        public DateTime dtm_crt { get; set; }

        public string usr_upd { get; set; }

        public DateTime dtm_upd { get; set; }
    }
}
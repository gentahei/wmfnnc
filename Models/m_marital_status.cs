using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.Models
{
    public class m_marital_status
    {
        [Key]
        public Guid m_marital_status_id { get; set; }

        public string marital_status_desc { get; set; }
    }
}
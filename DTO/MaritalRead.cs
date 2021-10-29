using System;
using System.ComponentModel.DataAnnotations;

namespace Wmfnnc.DTO
{
    public class MaritalRead
    {
        public Guid m_marital_status_id { get; set; }

        public string marital_status_desc { get; set; }
    }
}
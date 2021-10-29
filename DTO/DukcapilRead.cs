using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.DTO
{
    public class DukcapilRead
    {
        public Guid m_dukcapil_data_id { get; set; }

        public string nik { get; set; }

        public string name { get; set; }

        public string maiden_name { get; set; }

        public DateTime birth_date { get; set; }

        public string gender { get; set; }

        public ReligionRead religion { get; set; }

        public MaritalRead marital { get; set; }
    }
}
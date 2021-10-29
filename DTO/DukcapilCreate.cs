using System;
using System.ComponentModel.DataAnnotations;

namespace Wmfnnc.DTO
{
    public class DukcapilCreate
    {
        [Required]
        public string nik { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string maiden_name { get; set; }

        [Required]
        public DateTime birth_date { get; set; }

        [Required]
        public string gender { get; set; }

        [Required]
        public Guid religion_id { get; set; }

        [Required]
        public Guid marital_status { get; set; }
    }
}
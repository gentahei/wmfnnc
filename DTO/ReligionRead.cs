using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.DTO
{
    public class ReligionRead
    {
        public Guid religion_id { get; set; }

        public string religion_name { get; set; }
    }
}
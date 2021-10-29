using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wmfnnc.DTO
{
    public class DukcapilFind
    {
        [Required]
        public string nik { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Newhomes.Models
{
    [Index(nameof(Id))]
    public class NumericalModel
    {
        public int Id { get; set; }

        [Required, NotNull]
        public int? Number1 { get; set; }

        [Required, NotNull]
        public int? Number2 { get; set; }

        public int? Result { get; set; }
    }
}

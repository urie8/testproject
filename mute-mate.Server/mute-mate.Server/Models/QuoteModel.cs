﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mute_mate.Server.Models
{
    public class QuoteModel
    {
        [Key]
        public int Id { get; set; }

        [Column("quote")]
        public string Quote { get; set; } = null!;

        [Column("category")]
        public string Category { get; set;}

    }
}
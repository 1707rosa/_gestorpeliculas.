﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieManager.Api.Requests
{
    public class NewMovieRequest
    {

        [Required]
        public string Title { get; set; }

        public string Director { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }

        public string Genre { get; set; }

        [Range(0, 10)]
        [Column(TypeName = "decimal(3,1)")]
        public decimal Rating { get; set; }
    }
}

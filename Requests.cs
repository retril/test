using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace task1.Models
{
    class PostTaskRequest
    {
        [Required]
        public DateTime data;
        [Required]
        [StringLength(64)]
        public string title;
        [Required]
        [StringLength(200)]
        public string discription;
        [Required]
        public int complete;
    }
}

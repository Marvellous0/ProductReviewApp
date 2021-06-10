using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductReviewApp.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
       
    }
}
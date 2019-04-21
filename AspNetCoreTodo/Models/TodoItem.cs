using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        public string OwnerId { get; set; }
        
        public string Title { get; set; }

        public DateTimeOffset? DueAt { get; set; }
    }
}
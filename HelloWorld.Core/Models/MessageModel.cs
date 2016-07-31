using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Core.Models
{
    public class MessageModel
    {
        [Required]
        public string Message { get; set; }
    }
}
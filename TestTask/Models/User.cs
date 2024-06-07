using System.Text.Json.Serialization;
using TestTask.Enums;

namespace TestTask.Models
{
    /// <summary>
    /// User.
    /// DO NOT change anything here.
    /// </summary>
    public class User
    {
        public int Id { get; set; } 

        public string Email { get; set; }

        public UserStatus Status { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public virtual List<Order> Orders { get; set; }
    }
}

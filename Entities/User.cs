using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public string lastname { get; set; }
        public long Telephone { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public string Birthdate { get; set; }
        public int RoleId { get; set; }
        public List<Permission> Permissions { get; } = new();

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }


    }
}
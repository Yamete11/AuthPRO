using System.ComponentModel.DataAnnotations;

namespace AuthBE.Entities
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }

    }
}

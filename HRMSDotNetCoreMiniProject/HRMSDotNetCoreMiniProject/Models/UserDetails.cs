using System.ComponentModel.DataAnnotations;

namespace HRMSDotNetCoreMiniProject.Models
{
    public class UserDetails
    {

        [Key]
        public int userid { get; set; }

        public string username { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        public string userrole { get; set; }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using Welcome.Others;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Model
{
    public class DataBaseUser : User
    {
        private int _Id;

        public DataBaseUser(string? name, string? password, UsersRolesEnum role) : base(name, password, role)
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id
        {
            get => _Id;
            set => _Id = value;
        }
    }
}

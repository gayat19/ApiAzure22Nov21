using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Interfaces
{
    public interface IUser
    {
        public IEnumerable<UserDTO> GetUsers();
        public User Login(User user);
    }
}

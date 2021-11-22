using FirstAPI.Interfaces;
using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Services
{
    public class UserService : IUser
    {
        private readonly HrContext _context;

        public UserService()
        {

        }
        public UserService(HrContext context)
        {
            _context = context;
        }
        public IEnumerable<UserDTO> GetUsers()
        {
            List<UserDTO> users = new List<UserDTO>();
            foreach (var item in _context.Users)
            {
                UserDTO dto = new UserDTO();
                dto.Name = item.Name;
                dto.Role = item.Role;
                users.Add(dto);
            }
            return users;
        }

        public User Login(User user)
        {
            var myUser = _context.Users.Where(u => u.Id == user.Id && u.Password == user.Password).SingleOrDefault();
            return myUser;
        }
    }
}

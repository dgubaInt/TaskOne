using Microsoft.EntityFrameworkCore;
using TaskOne.Data;
using TaskOne.Models;
using TaskOne.Repositories.Interfaces;
using TaskOne.ViewModels;

namespace TaskOne.Repositories
{
    public class UserDataRepository : IUserDataRepository
    {
        private readonly UserDbContext _userDbContext;

        public UserDataRepository(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public async Task<bool> RegisterData(UserViewModel userViewModel)
        {
            try
            {
                User user = new()
                {
                    FirstName = userViewModel.FirstName,
                    LastName = userViewModel.LastName,
                    Option = userViewModel.Option
                };

                _userDbContext.Users.Add(user);
                await _userDbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IEnumerable<Tuple<string, int>>> GetStats()
        {
            var statsData = await _userDbContext.Users.GroupBy(u => u.Option)
                                                      .Select(g => new Tuple<string, int>(g.Key, g.Count()))
                                                      .ToListAsync();

            return statsData;
        }
    }
}

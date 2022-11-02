using TaskOne.ViewModels;

namespace TaskOne.Repositories.Interfaces
{
    public interface IUserDataRepository
    {
        Task<bool> RegisterData(UserViewModel userViewModel);
        Task<IEnumerable<Tuple<string, int>>> GetStats();
    }
}

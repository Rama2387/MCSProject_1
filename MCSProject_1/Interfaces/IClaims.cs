namespace MCSProject_1.Interfaces
{
    public interface IClaims<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T?> GetClaimById(decimal id);

    }
}

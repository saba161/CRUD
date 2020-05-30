using Microsoft.EntityFrameworkCore;

namespace Tree.Domain.Person1.Commands
{
    public interface Repository<T>
    {
        T Get(int entityId);
        void Entry(object obj, EntityState sate);
        void Store();
    }
}

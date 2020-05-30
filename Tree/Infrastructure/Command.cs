namespace Tree.Domain.Person1.Commands
{
    public interface Command<E>
    {
        Repository<E> Run(Repository<E> rep);
    }
}

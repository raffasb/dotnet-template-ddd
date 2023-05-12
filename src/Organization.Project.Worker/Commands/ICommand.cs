namespace Organization.Project.Worker.Commands
{
    public interface ICommand
    {
        Task ExecuteAsync(CancellationToken cancellationToken);
    }
}

namespace Exceptions
{
    public class WriterNotFoundException : Exception
    {
        public WriterNotFoundException(int writerId) : base($"Writer with ID {writerId} not found.")
        {
        }
    }
}

namespace Domain.Common;

public class ApplicationLayerException : Exception
{
    public ApplicationLayerException(string message) : base(message) { }
}

namespace BO;

[Serializable]
            
public class BlIdNotFoundException : Exception
{
    public BlIdNotFoundException(string? message) : base(message) { }
    public BlIdNotFoundException(string message, Exception innerException)
                : base(message, innerException) { }


}


[Serializable]
public class BlIdAlreadyExistsException : Exception
{
    public BlIdAlreadyExistsException(string? message) : base(message) { }
    public BlIdAlreadyExistsException(string message, Exception innerException)
                : base(message, innerException) { }

}


[Serializable]
public class BlNotFoundException : Exception
{
    public BlNotFoundException(string? message) : base(message) { }
    public BlNotFoundException(string message, Exception innerException)
                : base(message, innerException) { }

}



[Serializable]
public class BlInputNotValidException : Exception
{
    public BlInputNotValidException(string? message) : base(message) { }
    public BlInputNotValidException(string message, Exception innerException)
                : base(message, innerException) { }


}




[Serializable]
public class BlNotEnoughInStockException : Exception
{
    public BlNotEnoughInStockException(string? message) : base(message) { }
    public BlNotEnoughInStockException(string message, Exception innerException)
                : base(message, innerException) { }

}

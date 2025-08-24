
namespace DalFacade.DO;




[Serializable]
public class DalIdNotFoundException : Exception
{
    public DalIdNotFoundException(string exception) : base(exception)
    {

    }

    public DalIdNotFoundException()
    {

    }

}


[Serializable]
public class DalIdAlreadyExistsException : Exception
{
    public DalIdAlreadyExistsException(string exception) : base(exception)
    {

    }

    public DalIdAlreadyExistsException()
    {

    }
}


[Serializable]
public class DalNotFoundException : Exception
{
    public DalNotFoundException(string exception) : base(exception)
    {

    }

    public DalNotFoundException()
    {

    }

}




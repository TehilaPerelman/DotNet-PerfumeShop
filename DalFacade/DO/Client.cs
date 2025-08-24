

namespace DO;

/// <summary>
/// 
/// </summary>
/// <param name="id">ת"ז לקוח</param>
/// <param name="name_client">שם לקוח</param>
/// <param name="address">כתובת לקוח</param>
/// <param name="phone">טלפון</param>

public record Client
  (
   int id = 0,
   string? name_client = null,
   string? address = null,
   string? phone = null
   )
{


    public Client() : this(0)
    {

    }




}


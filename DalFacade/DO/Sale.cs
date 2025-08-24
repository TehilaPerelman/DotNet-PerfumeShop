

namespace DO;

/// <summary>
/// 
/// </summary>
/// <param name="id">מספר מזהה של המוצר</param>
/// <param name="count_sale">כמות נדרשת לקבלת המבצע</param>
/// <param name="UniqueId">מספר מזהה ייחודי</param>
/// <param name="price_sale">מחיר כולל במבצע</param>
/// <param name="club">האם המבצע מיועד לכולם</param>
/// <param name="start">תאריך תחילת המבצע</param>
/// <param name="end">תאריך סיום המבצע</param>
public record Sale
    (
    int id = 0,
    int count_sale = 0,
    int UniqueId = 0,
    int price_sale = 0,
    bool? club = null,
    DateTime? start = null,
    DateTime? end = null

    )
{
    public Sale() : this(0)
    {


    }
}

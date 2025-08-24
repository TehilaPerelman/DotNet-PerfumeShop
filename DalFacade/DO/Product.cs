

namespace DO;
/// <param name="id">מספר מזהה יחודי</param>
/// <param name="ProductName">שם מוצר</param>
/// <param name="category">קטגוריה</param>
/// <param name="price_product">מחיר</param>
/// <param name="count">כמות במלאי</param>
public record Product
    (
    int id = 0,
    string? ProductName = null,
    perfume? category = null,
    int price_product = 0,
    int count = 0

    )
{
    public Product() : this(0)
    {

    }


}

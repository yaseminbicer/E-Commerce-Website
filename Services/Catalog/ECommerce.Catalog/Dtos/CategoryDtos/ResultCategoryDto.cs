using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerce.Catalog.Dtos.CategoryDtos
{
    public class ResultCategoryDto
    {
        //Category işlemlerinde listelemek istediğimiz propertileri tutar
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

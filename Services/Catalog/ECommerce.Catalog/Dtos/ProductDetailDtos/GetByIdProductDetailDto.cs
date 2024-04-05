using ECommerce.Catalog.Entities;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace ECommerce.Catalog.Dtos.ProductDetailDtos
{
    public class GetByIdProductDetailDto
    {
        public string ProductDetailID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductInfo { get; set; }
        public string ProductId { get; set; }

    }
}

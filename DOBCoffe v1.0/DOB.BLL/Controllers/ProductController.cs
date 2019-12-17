using DOB.BLL.Abstract;
using DOB.DAL;
using DOB.DAL.Abstract;
using DOB.DTO;
using DOB.Entity.Entitys;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.BLL.Controllers
{
    public class ProductController:IProductService
    {
        IUnitofWork _uow;
        public ProductController()
        {
            _uow = Singleton.Uow;
            //_db = new DOBDbContext();
        }
        public ServiceResult ProductAdd(ProductDTO dto)
        {
            Product Product = new Product
            {
                Id = dto.ProductID,
                ProductName = dto.ProductName,
                ProductType = dto.ProductType,
                UnitPrice = dto.UnitPrice,
                Description = dto.Description,
                IsDeleted = dto.IsDeleted,
                Discountinued = dto.Discountinued,
                UserId = dto.UserId,
                CreatedDate = dto.CreatedDate
               
        };
            ServiceResult result;
            try
            {
                bool islemYapildimi = _uow.GetRepository<Product>().Add(Product);
                if (islemYapildimi)
                {
                    result = new ServiceResult("Kayıt başarılı.", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Kayıt sırasında bir hata oluştu.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {

                result = new ServiceResult("Kayıt bir hata nedeniyle başarısız oldu", ResultState.Error);
            }
            return result;
        }

        public List<ProductDTO> ListProducts()
        {
            ICollection<Product> Product = _uow.GetRepository<Product>().Get(p => p.IsDeleted == false);
            return ProductToDto(Product);
        }

        public ServiceResult ProductDelete(ProductDTO dto)
        {
            var Product = _uow.GetRepository<Product>().Get(dto.ProductID);
            Product.IsDeleted = true;

            try
            {
                if (_uow.GetRepository<Product>().Update(Product))
                {
                    return new ServiceResult("Silme işlemi başarılıdır", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("İşlem yapılacak kayıt bulunamadı.", ResultState.Warning);
                }
            }
            catch (Exception ex)
            {

                return new ServiceResult("Silme işleminde bir hata meydana geldi.", ResultState.Error);
            }
        }

        public ServiceResult ProductUpdate(ProductDTO dto)
        {
            var Product = _uow.GetRepository<Product>().Get(dto.ProductID);
            DtoToProduct(dto, Product);
            try
            {
                if (_uow.GetRepository<Product>().Update(Product))
                {
                    return new ServiceResult("Güncelleme başarılı.", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("Kullanıcıda herhangi bir değişiklik yapmadınız.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                return new ServiceResult("Güncelleme işlemi bir hata nedeniyle tamamlanamadı!", ResultState.Error);

            }
        }

        private void DtoToProduct(ProductDTO dto, Product Product)
        {
            Product.Id = dto.ProductID;
            Product.ProductName = dto.ProductName;
            Product.ProductType = dto.ProductType;
            Product.UnitPrice = dto.UnitPrice;
            Product.Description = dto.Description;
            Product.UnitOnStock = dto.UnitOnStock;
            Product.Discountinued = dto.Discountinued;
        }

        private void ProductToDto(Product Product, ProductDTO dto)
        {
            dto.ProductID = Product.Id;
            dto.ProductName = Product.ProductName;
            dto.ProductType = Product.ProductType;
            dto.UnitPrice = Product.UnitPrice;
            dto.Description = Product.Description;
            dto.UnitOnStock = Product.UnitOnStock;
            dto.Discountinued = Product.Discountinued;
        }

        private List<ProductDTO> ProductToDto(IEnumerable<Product> Products)
        {
            List<ProductDTO> result = new List<ProductDTO>();
            foreach (var Product in Products)
            {
                ProductDTO dto = new ProductDTO();
                ProductToDto(Product, dto);
                result.Add(dto);
            }
            return result;
        }

    }
}

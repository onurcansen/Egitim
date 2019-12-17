using DOB.DAL;
using DOB.DAL.Abstract;
using DOB.DTO;
using DOB.Entity.Entitys;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOB.BLL.Controllers
{
    public class OrderController
    {
        IUnitofWork _uow;
        public OrderController()
        {
            _uow = Singleton.Uow;
        }
      
        public ServiceResult SiparisEkle(OrderDTO dto,OrderDetailDTO odto)
        {

            Order order = new Order();

            OrderDetail orderdetail = new OrderDetail();
            order.Id = Guid.NewGuid();
            orderdetail.Id = Guid.NewGuid();
            order.CustomerId = dto.CustomerID;
            order.PreparedId = dto.PreparedID;
            order.BranchId = dto.BranchID;
            order.OrderDate = dto.OrderDate;
            order.IsApproved = dto.IsApproved;
            order.IsPrepared = dto.IsPrepared;
            orderdetail.OrderID = order.Id;
            orderdetail.ProductID = odto.ProductID;
                       
            ServiceResult result;
            try
            {
                bool IslemYapildiMi = _uow.GetRepository<Order>().Add(order)&&_uow.GetRepository<OrderDetail>().Add(orderdetail);
                if (IslemYapildiMi)
                {
                    result = new ServiceResult("İşlem başarılı", ResultState.Success);


                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına ratlanmadı.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                result = new ServiceResult("Hata: ProductController-34", ResultState.Error);
            }
            return result;

        }

        public List<OrderDTO> TumSiparisleriVer()
        {
            ICollection<Order> orders = _uow.GetRepository<Order>().Get(p => p.IsDeleted == false);
            return OrderToDto(orders);
        }

        public ServiceResult SiparisGüncelle(OrderDTO dto)
        {
            var order = _uow.GetRepository<Order>().Get(dto.OrderID);
            DtoToOrder(dto, order);
            try
            {
                if (_uow.GetRepository<Order>().Update(order))
                {
                    return new ServiceResult("Güncelleme başarılır", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("Herhangi bir değişiklik yapılmamıştır.", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                return new ServiceResult("Hata", ResultState.Error);
            }

        }

        public ServiceResult SiparisSil(OrderDTO dto)
        {
            var order = _uow.GetRepository<Order>().Get(dto.OrderID);
            order.IsDeleted = true;
            try
            {
                if (_uow.GetRepository<Order>().Update(order))
                {
                    return new ServiceResult("Silme işlemi başarılıdır", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("İşlem yapılacak kayıt bulunamamıştır", ResultState.Warning);
                }
            }
            catch (Exception)
            {
                return new ServiceResult("Hata", ResultState.Error);
            }
        }

        private void DtoToOrder(OrderDTO dto, Order order)
        {
            order.Id = dto.OrderID;
            order.CustomerId = dto.CustomerID;
            order.PreparedId = dto.PreparedID;
            order.OrderDate = dto.OrderDate;
            order.IsApproved = dto.IsApproved;
            order.IsPrepared = dto.IsPrepared;
            order.IsDeleted = dto.IsDeleted;
        }

        private void OrderToDTO(Order order, OrderDTO dto)
        {
            dto.OrderID = order.Id;
            dto.CustomerID = order.CustomerId;
            dto.PreparedID = order.PreparedId;
            dto.BranchID = order.BranchId;
            dto.OrderDate = order.OrderDate;
            dto.IsApproved = order.IsApproved;
            dto.IsPrepared = order.IsPrepared;
            dto.IsDeleted = order.IsDeleted;
        }



        private List<OrderDTO> OrderToDto(IEnumerable<Order> orders)
        {
            List<OrderDTO> result = new List<OrderDTO>();
            foreach (var order in orders)
            {
                OrderDTO dto = new OrderDTO();
                OrderToDTO(order, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}

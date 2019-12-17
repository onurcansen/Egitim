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
    public class CustomerController
    {
        IUnitofWork _uow;
        public CustomerController()
        {
            _uow = Singleton.Uow;
        }
        public ServiceResult CustomerAdd(CustomerDTO dto)
        {




            Customer customer = new Customer
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                EMail = dto.EMail,
                BirthDate = dto.BirthDate,
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                UserId = dto.User.Id,
                IsDeleted = false,
                IsActive = true                           
        };
            ServiceResult result;
            try
            {
                bool islemYapildimi= _uow.GetRepository<Customer>().Add(customer);
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

        public List<CustomerDTO> ListCustomers()
        {
            ICollection<Customer> customer = _uow.GetRepository<Customer>().Get(p => p.IsDeleted == false);
            return CustomerToDto(customer);
        }

        public ServiceResult CustomerDelete(CustomerDTO dto)
        {
            var customer = _uow.GetRepository<Customer>().Get(dto.ID);
            customer.IsDeleted = true;

            try
            {
                if (_uow.GetRepository<Customer>().Update(customer))
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

        public ServiceResult CustomerUpdate(CustomerDTO dto)
        {
            var customer = _uow.GetRepository<Customer>().Get(dto.ID);
            DtoToCustomer(dto, customer);
            try
            {
                if (_uow.GetRepository<Customer>().Update(customer))
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

        private void DtoToCustomer(CustomerDTO dto, Customer customer)
        {
            customer.Id = dto.ID;
            customer.FirstName = dto.FirstName;
            customer.LastName = dto.LastName;
            customer.Phone = dto.Phone;
            customer.BirthDate = dto.BirthDate;
            customer.EMail = dto.EMail;
            customer.UserId = dto.User.Id;
        }

        private void CustomerToDto(Customer customer, CustomerDTO dto)
        {
            dto.ID = customer.Id;
            dto.FirstName = customer.FirstName;
            dto.LastName = customer.LastName;
            dto.Phone = customer.Phone;
            dto.BirthDate = customer.BirthDate;
            dto.EMail = customer.EMail;
            dto.User.Id =customer.UserId;
        }

        private List<CustomerDTO> CustomerToDto(IEnumerable<Customer> customers)
        {
            List<CustomerDTO> result = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                CustomerDTO dto = new CustomerDTO();
                CustomerToDto(customer, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}

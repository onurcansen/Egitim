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
    public class EmployeeController
    {
        IUnitofWork _uow;
        public EmployeeController()
        {
            _uow = Singleton.Uow;
        }
        public ServiceResult EmployeeAdd(EmployeeDTO dto)
        {
            Employee employee = new Employee
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                EMail = dto.EMail,               
                BirthDate = dto.BirthDate,
                Id = Guid.NewGuid(),
               // BranchID=dto.BranchID,

               // CreatedDate = DateTime.Now,
                //UserId = dto.User.Id,
               // IsDeleted = false,
               // IsActive = true,
            };
            ServiceResult result;
            try
            {
                bool islemYapildimi = _uow.GetRepository<Employee>().Add(employee);
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

        public List<EmployeeDTO> ListEmployees()
        {
            ICollection<Employee> Employee = _uow.GetRepository<Employee>().Get(p => p.IsDeleted == false);
            return EmployeeToDto(Employee);
        }

        public ServiceResult EmployeeDelete(EmployeeDTO dto)
        {
            var Employee = _uow.GetRepository<Employee>().Get(dto.ID);
            Employee.IsDeleted = true;

            try
            {
                if (_uow.GetRepository<Employee>().Update(Employee))
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

        public ServiceResult EmployeeUpdate(EmployeeDTO dto)
        {
            var Employee = _uow.GetRepository<Employee>().Get(dto.ID);
            DtoToEmployee(dto, Employee);
            try
            {
                if (_uow.GetRepository<Employee>().Update(Employee))
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

        private void DtoToEmployee(EmployeeDTO dto, Employee Employee)
        {
            Employee.Id = dto.ID;
            Employee.FirstName = dto.FirstName;
            Employee.LastName = dto.LastName;
            Employee.Phone = dto.Phone;
            Employee.BirthDate = dto.BirthDate;
            Employee.EMail = dto.EMail;
            Employee.UserId = dto.User.Id;
        }

        private void EmployeeToDto(Employee Employee, EmployeeDTO dto)
        {
            dto.ID = Employee.Id;
            dto.FirstName = Employee.FirstName;
            dto.LastName = Employee.LastName;
            dto.Phone = Employee.Phone;
            dto.BirthDate = Employee.BirthDate;
            dto.EMail = Employee.EMail;
            dto.User.Id = Employee.UserId;
            
        }

        private List<EmployeeDTO> EmployeeToDto(IEnumerable<Employee> Employees)
        {
            List<EmployeeDTO> result = new List<EmployeeDTO>();
            foreach (var Employee in Employees)
            {
                EmployeeDTO dto = new EmployeeDTO();
                EmployeeToDto(Employee, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}

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
    public class LoginController
    {
        IUnitofWork _uow;
        public LoginController()
        {
            _uow = Singleton.Uow;
        }
        public ServiceResult Login(string user, string pass)
        {
            ServiceResult result;
            try
            {
                var kullanici = _uow.GetRepository<User>().Get(u => u.UserName == user && u.Password == pass).FirstOrDefault();
                if (kullanici == null)
                {
                    result = new ServiceResult("Login sırasında bir hata oluştu.", ResultState.Warning);
                }
                else
                {
                    //mappleme yapılacak;
                    //userı userdtoya çevir!!!
                    UserDTO _userdto = new UserDTO();
                    UserToDto(kullanici, _userdto);
                    Session.CurrentUser = _userdto;

                    //role ü roledtoya çevir!!!
                    var role = kullanici.Roles;
                    List<RoleDTO> rdto = new List<RoleDTO>();
                    rdto = RoleToDto(role);
                    Session.CurrentRole = rdto;
                    result = new ServiceResult("Login başarılıdır.", ResultState.Success);


                }

            }
            catch (Exception ex)
            {
                result = new ServiceResult("İşlem bir hata nedeniyle başarısız oldu", ResultState.Error);
            }
            return result;


        }
        public int HasRole()
        {
            int rol=0;
            if (Session.CurrentRole.Where(r=>r.RoleName=="Admin").SingleOrDefault()!=null)
            {
                rol++;

            }
            if (Session.CurrentRole.Count(r => r.RoleName == "Customer") == 1)
            {
                rol++;

            }

            if (Session.CurrentRole.Count(r => r.RoleName == "Employee") == 1)
            {
                rol++;

            }
            
            return rol;

        }
        

        public ServiceResult UserAdd(UserDTO dto)
        {
            User user = new User
            {

                Id = Guid.NewGuid(),
                UserName = dto.UserName,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = dto.UserId
            };
            ServiceResult result;
            try
            {
                bool islemYapildimi = _uow.GetRepository<User>().Add(user);
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

        public List<UserDTO> ListUsers()
        {
            ICollection<User> user = _uow.GetRepository<User>().Get(p => p.IsDeleted == false);
            return UserToDto(user);
        }

        public ServiceResult CustomerDelete(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().Get(dto.Id);
            user.IsDeleted = true;

            try
            {
                if (_uow.GetRepository<User>().Update(user))
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

        public ServiceResult UserUpdate(UserDTO dto)
        {
            var user = _uow.GetRepository<User>().Get(dto.Id);
            DtoToUser(dto, user);
            try
            {
                if (_uow.GetRepository<User>().Update(user))
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

        private void DtoToUser(UserDTO dto, User user)
        {
            user.Id = dto.Id;
            user.UserName = dto.UserName;
            user.Password = dto.Password;
            user.Roles = dto.Roles;
            user.UserId = dto.UserId;
        }

        private void UserToDto(User user, UserDTO dto)
        {
            dto.Id = user.Id;
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            dto.Roles = user.Roles;
            dto.UserId = user.UserId;
        }

        private List<UserDTO> UserToDto(IEnumerable<User> users)
        {
            List<UserDTO> result = new List<UserDTO>();
            foreach (var item in users)
            {
                UserDTO dto = new UserDTO();
                UserToDto(item, dto);
                result.Add(dto);
            }
            return result;
        }
        private void RoleToDto(Role role, RoleDTO rdto)
        {
            rdto.RoleId = role.Id;
            rdto.RoleName = role.RoleName;
            rdto.Users = role.Users;
            rdto.UserId = role.UserId;
        }
        
        private List<RoleDTO> RoleToDto(IEnumerable<Role> roles)
        {
            List<RoleDTO> result = new List<RoleDTO>();
            foreach (var item in roles)
            {
                RoleDTO dto = new RoleDTO();
                RoleToDto(item, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}

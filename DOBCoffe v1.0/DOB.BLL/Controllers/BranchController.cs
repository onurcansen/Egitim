using DOB.DAL;
using DOB.DAL.Abstract;
using DOB.DTO;
using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.BLL.Controllers
{
    public class BranchController
    {

        IUnitofWork _uow;
        public BranchController()
        {
            _uow = Singleton.Uow;
        }

        public List<BranchDTO> TumSubeleriVer()
        {
            ICollection<Branch> branchs = _uow.GetRepository<Branch>().Get(p => p.IsDeleted == false);
            return BranchToDto(branchs);
        }

        private void DtoToBranch(BranchDTO dto, Branch branchs)
        {
            branchs.Id = dto.ID;
            branchs.BranchName = dto.BranchName;
            branchs.BranchAdress = dto.BranchAdress;
            branchs.IsDeleted = dto.IsDeleted;   
           
        }

        private void BranchToDTO(Branch branchs, BranchDTO dto)
        {
            dto.ID = branchs.Id;
            dto.BranchName = branchs.BranchName;
            dto.BranchAdress = branchs.BranchAdress;
            dto.IsDeleted = branchs.IsDeleted;

            
        }



        private List<BranchDTO> BranchToDto(IEnumerable<Branch> branchs)
        {
            List<BranchDTO> result = new List<BranchDTO>();
            foreach (var item in branchs)
            {
                BranchDTO dto = new BranchDTO();
                BranchToDTO(item, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}

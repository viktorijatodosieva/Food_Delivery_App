using EShop.Domain.Domain;
using EShop.Repository;
using EShop.Repository.Implementation;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class PartnerService : IPartnerService
    {
        private readonly IPartnerRepository _partnerRepository;


        public PartnerService(IPartnerRepository partnerRepository)
        {
            _partnerRepository = partnerRepository;
        }

        public List<PartnerBook> GetAllBooks()
        {
            return _partnerRepository.GetAllBooks();
        }
    }
}

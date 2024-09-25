using EShop.Domain.Domain;
using EShop.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository.Implementation
{

    public class PartnerRepository : IPartnerRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<PartnerBook> entities;

        public PartnerRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<PartnerBook>();
        }
        public List<PartnerBook> GetAllBooks()
        {
            return entities
               .Include(z => z.Name)
               .ToList();
        }
    }
}

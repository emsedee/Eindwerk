using eindwerk.Data;
using eindwerk.Entities;
using eindwerk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eindwerk.Services
{
    public class MenuMasterService : IMenuMasterService
    {
        private readonly DatabaseEindWerkContext _dbContext;

        public MenuMasterService(DatabaseEindWerkContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<MenuMaster> GetMenuMaster()
        {
            return _dbContext.MenuMaster.AsEnumerable();

        }

        public IEnumerable<MenuMaster> GetMenuMaster(string UserRole)
        {
            var result = _dbContext.MenuMaster.Where(m => m.User_Roll == UserRole).ToList();
            return result;
        }
    }
}

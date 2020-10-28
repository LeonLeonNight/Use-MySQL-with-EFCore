using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.DataAccess.Entities;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PublisherController : Controller
    {
        public DbContextApp _dbContext;
        public PublisherController(DbContextApp dbContext)
        {
            _dbContext = dbContext;
        }

        
    }
}

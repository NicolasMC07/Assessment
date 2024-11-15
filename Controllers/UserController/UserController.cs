using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Data;
using Microsoft.AspNetCore.Mvc;

namespace APiClinique.Controllers.UserController
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }
        

    }
}
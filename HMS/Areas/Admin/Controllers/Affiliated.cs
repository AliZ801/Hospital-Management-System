using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HMS.DataAccess.Data.IRepository;
using HMS.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Affiliated : Controller
    {
        private readonly IUnitofWork _unitofWork;

        [BindProperty]
        public AdminViewModels AVM { get; set; }

        public Affiliated(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

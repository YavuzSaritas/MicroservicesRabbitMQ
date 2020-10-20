using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MicroRabbit.MVC.Models;
using MicroRabbit.MVC.Services;
using MicroRabbit.MVC.Models.DTO;

namespace MicroRabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
       private readonly ITransferService _transferService;

        public HomeController(ITransferService transferService)
        {
            _transferService = transferService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferVM model)
        {
            var transferDto = new TransferDTO
            {
                FromAccount = model.FromAccount,
                ToAccount = model.ToAccount,
                TransferAmount = model.TransferAmount
            };
            await _transferService.Transfer(transferDto);

            return View("Index");
        }
    }
}

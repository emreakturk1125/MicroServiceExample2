using Course.Services.Basket.Dtos;
using Course.Services.Basket.Services;
using Course.Shared.ControllerBases;
using Course.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services.Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : CustomBaseController
    {
        private readonly IBasketService _basketService;
        private readonly ISharedIdentityService _sharedIdentityService;

        public BasketsController(IBasketService basketService, ISharedIdentityService sharedIdentityService)
        {
            _basketService = basketService;
            _sharedIdentityService = sharedIdentityService;
        }

        //Shared servis üzerinden json web token dan userId bilgisini aldığımız için burada metoda parametre olarak almadık
        [HttpGet]
        public async Task<IActionResult> GetBasket()
        { 
            return CreateActionResultInstance(await _basketService.GetBasket(_sharedIdentityService.GetUserId));
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrUpdateBasket(BasketDto basketDto)
        {
            basketDto.UserId = _sharedIdentityService.GetUserId;
            var response = await _basketService.SaveOrUpdate(basketDto);

            return CreateActionResultInstance(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBasket()

        {
            return CreateActionResultInstance(await _basketService.Delete(_sharedIdentityService.GetUserId));
        }
    }
}
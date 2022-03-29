using FoodOrderingWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebApplicationApi.Models;

namespace ASPWebApi.Controllers
{
    public class OrderApiController : Controller
    {
        private readonly IOrderRepository _iOrderRepository;

        public OrderApiController(IOrderRepository OrderRepository)
        {
            this._iOrderRepository = OrderRepository;
        }

        [HttpGet]
        [Route("api/Orders/Get")]
        public async Task<IEnumerable<Order>> Get()
        {
            return await _iOrderRepository.GetOrder();
        }
        [HttpPost]
        [Route("api/Orders/Create")]
        public async Task CreateAsync([FromBody] Order Order)
        {
            if (ModelState.IsValid)
            {
                await _iOrderRepository.Add(Order);
            }
        }
        [HttpGet]
        [Route("api/Orders/Details/{id}")]
        public async Task<Order> Details(int id)
        {
            var result = await _iOrderRepository.GetOrder(id);
            return result;
        }
        //[HttpPut]
        //[Route("api/Orders/Edit/{id}")]
        ////public async Task EditAsync(int id, [FromBody] Order Order)
        //public async Task EditAsync(int id, Order Order)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _iOrderRepository.Update(id, Order);
        //    }
        //}
        //[HttpDelete]
        //[Route("api/Orders/Delete/{id}")]
        //public async Task DeleteConfirmedAsync(int id)
        //{
        //    await _iOrderRepository.Delete(id);
        //}
    }
}

using APBD_Task_6.Models;
using APBD_Zadanie_6.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_Zadanie_6.Controllers
{
    [Route("api/warehouses2")]
    [ApiController]
    public class WarehousesProcedureController : ControllerBase
    {
        private readonly IWarehouseProcedureService _warehouseProcedureService;

        public WarehousesProcedureController(IWarehouseProcedureService warehouseprocedureService)
        {
            _warehouseProcedureService = warehouseprocedureService;
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToWarehouseAsync(ProductWarehouse productWarehouse)
        {
            int idProductWarehouse = await _warehouseProcedureService.AddProductWarehouseAsync(productWarehouse);

            return Ok(idProductWarehouse);
        }
    }
}

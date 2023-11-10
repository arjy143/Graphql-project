using Microsoft.AspNetCore.Mvc;
using static GraphQLDemo.Order;

namespace GraphQLDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController :
   ControllerBase
    {
        private ISupplierRepository
        _supplierRepository;
        public SupplierController
        (ISupplierRepository
        supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        [HttpGet("{id}")]
        public async Task<Supplier>
        GetSupplier(int id)
        {
            return await
            _supplierRepository.GetSupplier(id);
        }
        [HttpGet("GetSuppliers")]
        public async Task<List
        <Supplier>> GetSuppliers()
        {
            return await
           _supplierRepository.GetSuppliers();

        }
    }
}

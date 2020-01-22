using CoreApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreApi.Controllers
{
    [Route("api/encryption")]
    [ApiController]
    public class CipherController : ControllerBase
    {
        private readonly ICipherService _cipherService;

        public CipherController(ICipherService cipherService)
        {
            _cipherService = cipherService;
        }

        [HttpGet("encrypt")]
        public string Encrypt(string password)
        {
            return _cipherService.Encrypt(password);
        }
    }
}

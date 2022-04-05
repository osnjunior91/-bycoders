using Bycoders.Domain.Core.Services.Upload;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bycoders.Api.Controllers
{
    [Route("api/v1/bulk")]
    [ApiController]
    public class BulkController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;
        public BulkController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }
        [Route("file/upload")]
        [HttpPost]
        [ProducesResponseType(typeof(string), 201)]
        [ProducesResponseType(typeof(string), 500)]
        public async Task<IActionResult> FileUpload([FromForm]IFormFile file)
        {
            try
            {
                await _uploadFileService.UploadFileAsync(file);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

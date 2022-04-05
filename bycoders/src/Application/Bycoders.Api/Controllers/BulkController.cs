using Bycoders.Domain.Core.Services.Upload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Bycoders.Api.Controllers
{
    /// <summary>
    /// Controler to load file in system
    /// </summary>
    [Route("api/v1/bulk")]
    [ApiController]
    public class BulkController : ControllerBase
    {
        private readonly IUploadFileService _uploadFileService;
        public BulkController(IUploadFileService uploadFileService)
        {
            _uploadFileService = uploadFileService;
        }
        /// <summary>
        /// Load .txt file for database of system, you need authentication to use this
        /// </summary>
        /// <param name="file">File .txt</param>
        /// <returns></returns>
        [Route("file/upload")]
        [HttpPost]
        [Authorize]
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

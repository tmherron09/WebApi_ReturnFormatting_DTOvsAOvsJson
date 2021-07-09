using DtoVsAnonymousVsJson_API.DTO;
using DtoVsAnonymousVsJson_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace DtoVsAnonymousVsJson_API.Controllers
{
    [Route("api/ao/[action]")]
    [ApiController]
    public class ApiReturnTestsController : ControllerBase
    {

        JsonSerializerOptions _jsonOptions = new JsonSerializerOptions() { IgnoreNullValues = true };

        [HttpGet("{id}")]
        public ActionResult<ItemDTO> GetItemDTO(int id)
        {
            if (id == 1)
            {
                var itemDTO = new ItemDTO() { Name = "Ball", Color = "Red", Count = 10 };
                return itemDTO;
            }
            else
            {
                return NotFound();
            }
        }


        /// <summary>
        /// Return an Anonymous Object as Json.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<object> GetItemAO(int id)
        {
            if (id == 1)
            {
                var itemDTO = new { Name = "Ball", Color = "Red", Count = 10 };
                return Ok(itemDTO);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItemJSONObj(int id)
        {
            if (id == 1)
            {

                var itemJson = new { Name = "Ball", Color = "Red", Count = 10 };
                return Ok(itemJson);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItemJSON(int id)
        {
            if (id == 1)
            {
                var itemDTO = new { Name = "Ball", Color = "Red", Count = 10 };
                string json = JsonConvert.SerializeObject(itemDTO);
                return Ok(json);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItemIgnoreNull(int id)
        {
            if (id == 1)
            {
                var item = new Item() { Name = "Ball", Color = "Red", Count = 10 };
                return new JsonResult(item, _jsonOptions);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItem(int id)
        {
            if (id == 1)
            {
                var item = new Item() { Name = "Ball", Color = "Red", Count = 10 };
                return new JsonResult(item);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetItemTwo(int id)
        {
            if (id == 1)
            {
                var item = new Item() { Name = "Ball", Color = "Red", Count = 10 };
                return Ok(item);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDTO> GetItemWithStoragesDTOIgnoreNull(int id)
        {
            if (id == 1)
            {
                var itemDTO = new ItemWithStorageDTO() { Name = "Ball", Color = "Red", Count = 10 };
                return new JsonResult(itemDTO, _jsonOptions);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItemWithStorages(int id)
        {
            if (id == 1)
            {
                var itemDTO = new ItemWithStorageDTO() { Name = "Ball", Color = "Red", Count = 10 };
                var storageOne = new Storage() { Name = "Closet", Location = "Classroom" };
                var storageTwo = new Storage() { Name = "Closet", Location = "Hallway" };
                var storageThree = new Storage() { Name = "Top Drawer", Location = "Teacher's Office" };
                itemDTO.Storages = new List<Storage>();
                itemDTO.Storages.Add(storageOne);
                itemDTO.Storages.Add(storageTwo);
                itemDTO.Storages.Add(storageThree);
                return new JsonResult(itemDTO, _jsonOptions);
            }
            else
            {
                return NotFound();
            }
        }

    }
}

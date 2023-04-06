using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoAppWithJWT.Data;
using TodoAppWithJWT.Models;

namespace TodoAppWithJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public TodoController(ApiDbContext context)
        {
            _context = context;
        }

        [Route("TestRun")]
        [HttpGet]
        public ActionResult TestRun()
        {
            return Ok("success");
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.ToListAsync();

            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> CreateItems(ItemData data)
        {
            if (ModelState.IsValid)
            {
                await _context.Items.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetItem", new { data.Id }, data);
            }

            return new JsonResult("Something went wrong") { StatusCode = 500 };
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _context.Items.FirstOrDefaultAsync(item => item.Id == id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        //Get Item Set String
        [Route("GetSearchString")]
        [HttpGet]
        public async Task<IActionResult> GetSearchString()
        {
            var searchString = Request.Query["searchString"].ToString();

            var items = _context
                            .Items
                            .Where(s => s.Title.ToLower().Contains(searchString.ToLower()));
            return Ok(await items.ToListAsync());
        }

        //Get Item Pagination
        [Route("GetPagination")]
        [HttpGet]
        public async Task<IActionResult> GetPagination()
        {
            var qpageSize = Request.Query["pageSize"];
            var qpageIndex = Request.Query["pageIndex"];

            var items = _context.Items;

            if (String.IsNullOrEmpty(qpageSize) || String.IsNullOrEmpty(qpageIndex))
            {
                return BadRequest("Please input pageSize and pageIndex!");
            }

            var pageSize = int.Parse(qpageSize);
            var pageIndex = int.Parse(qpageIndex);

            var totalData = await items.CountAsync();
            var totalPages = (int)Math.Ceiling(totalData / (double)pageSize);

            var data = await items.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return Ok(new { data, totalData, totalPages });
        }

        // Filtering + Sorting + Pagination
        [Route("PageData")]
        [HttpGet]
        public async Task<IActionResult> PageData()
        {
            var qpageSize = Request.Query["pageSize"];
            var qpageIndex = Request.Query["pageIndex"];
            var sortOrder = Request.Query["sortOrder"].ToString();
            var searchString = Request.Query["searchString"].ToString();

            if (String.IsNullOrEmpty(qpageSize) || String.IsNullOrEmpty(qpageIndex))
            {
                return BadRequest("Please input pageSize and pageIndex!");
            }

            var items = from i in _context.Items
                        select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items
                            .Where(s => s.Title.ToLower().Contains(searchString.ToLower()));
            }

            switch (sortOrder)
            {
                case "title_desc":
                    items = items.OrderByDescending(s => s.Title);
                    break;
                case "title_asc":
                    items = items.OrderBy(s => s.Title);
                    break;
                case "id_desc":
                    items = items.OrderByDescending(s => s.Id);
                    break;
                default:
                    items = items.OrderBy(s => s.Id);
                    break;
            }

            var pageSize = int.Parse(qpageSize);
            var pageIndex = int.Parse(qpageIndex);

            var totalData = await items.CountAsync();
            var totalPages = (int)Math.Ceiling(totalData / (double)pageSize);

            var data = await items.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            return Ok(new { data, totalData, totalPages });
        }

        // Sorting
        [Route("GetSortOrder")]
        [HttpGet]
        public async Task<IActionResult> GetSortOrder()
        {
            var sortOrder = Request.Query["sortOrder"].ToString();

            var items = from i in _context.Items
                        select i;
            switch (sortOrder)
            {
                case "title_desc":
                    items = items.OrderByDescending(s => s.Title);
                    break;
                case "title_asc":
                    items = items.OrderBy(s => s.Title);
                    break;
                case "id_desc":
                    items = items.OrderByDescending(s => s.Id);
                    break;
                default:
                    items = items.OrderBy(s => s.Id);
                    break;
            }

            return Ok(await items.ToListAsync());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, ItemData item)
        {
            if (id != item.Id)
                return BadRequest();

            var existItem = await _context.Items.FirstOrDefaultAsync(item => item.Id == id);

            if (existItem == null)
                return NotFound();

            existItem.Title = item.Title;
            existItem.Description = item.Description;
            existItem.Done = item.Done;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Items.FirstOrDefaultAsync(item => item.Id == id);

            if (existItem == null)
                return NotFound();

            _context.Items.Remove(existItem);
            await _context.SaveChangesAsync();

            return Ok(existItem);
        }
    }
}
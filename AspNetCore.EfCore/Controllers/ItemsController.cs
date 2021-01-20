using AspNetCoreBasics.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreBasics.Dtos;

namespace AspNetCoreBasics.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private AspNetCoreBasicsContext dbContext;

        private Func<Item, ItemDto> mapper = (item) =>
        {
            var itemdto = new ItemDto()
            {
                Id = item.Id,
                Item = item.Item1,
                Description = item.Description
            };
            itemdto.ItemDetails = item.ItemDetail?.Select(_ =>
                                        new ItemDetailDto()
                                        {
                                            Id = _.Id,
                                            Size = _.Size,
                                            Type = _.Type,
                                            ItemId = _.ItemId
                                        }).ToList();
            return itemdto;
        };

        public ItemsController(AspNetCoreBasicsContext AspNetCoreBasicsContext)
        {
            this.dbContext = AspNetCoreBasicsContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<ItemDto>>> GetItem()
        {
            var items = await dbContext.Item.ToListAsync();
            return items.Select(_=> mapper(_)).ToList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ItemDto>> GetItem(int id)
        {
            var item = await dbContext.Item
                                .Include(_ => _.ItemDetail)
                                .FirstOrDefaultAsync(_ => _.Id == id);
            return mapper(item);
        }

        [HttpPost]
        public async Task<ActionResult<ItemDto>> AddItem(Item item)
        {
            await dbContext.Item.AddAsync(item);
            await dbContext.SaveChangesAsync();
            return mapper(item);
        }
    }
}

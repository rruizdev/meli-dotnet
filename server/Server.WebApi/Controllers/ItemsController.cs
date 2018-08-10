﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Infrastructure.Services;
using Server.Infrastructure.Services.Interfaces;

namespace Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private IItemService _itemService;

        public ItemsController() => _itemService = new ItemService();

        // GET /api/items?q=:query
        [HttpGet(Name = nameof(GetItemsByQuery))]
        public async Task<IActionResult> GetItemsByQuery([FromQuery]string q) => 
            base.Ok(await _itemService.GetSearchResult(q));

        // GET /api/items/:id
        [HttpGet]
        [Route("{id}", Name = nameof(GetItemById))]
        public async Task<IActionResult> GetItemById(string id) => 
            base.Ok(await _itemService.GetItemResult(id));
    }
}

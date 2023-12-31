﻿using Core.Models;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepo _categoryRepo;

        public CategoriesController(ICategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Category>>> GetCategories()
        {
            IList<Category> categories = await _categoryRepo.GetCategoriesAsync();
            return Ok(categories);
        }
    }
}

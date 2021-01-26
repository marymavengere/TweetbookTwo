﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetbookTwo.Controllers
{
    public class PostsController : Controller
    {
        private List<Post> _posts;
        public PostsController()
        {
            _posts = new List<Post>();
            for (var i = 0; i < 5; i++)
            {
                _posts.Add(new Post{id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet("api/v1/posts")]
        public IActionResult GetAll()
        {
            return Ok(_posts);
        }
    }
}

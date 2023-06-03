﻿using MARShop.Core.Common;
using System.Collections.Generic;

namespace MARShop.Core.Entities
{
    public class BlogPost : AuditableEntity
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public int Views { get; set; }
        public int Like { get; set; }
        public IList<BlogPostTag> BlogPostTags { get; set; }
        public IList<AccountBlogPost> AccountBlogPosts { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
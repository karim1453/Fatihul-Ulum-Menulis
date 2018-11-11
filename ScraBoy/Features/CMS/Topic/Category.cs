﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ScraBoy.Features.CMS.Topic
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
    }
}
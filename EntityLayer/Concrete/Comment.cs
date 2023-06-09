﻿using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment:IEntity
    {
        [Key]
        public int CommentId { get; set; }

        [StringLength(200)]
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }

        [StringLength(20)]
        public string Subject { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}

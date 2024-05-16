using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.v1.Core.Model
{
    public class Category : BaseEntity
    {
        public ICollection<Article> Articles { get; set; }

    }
}

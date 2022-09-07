using System;
using System.Collections.Generic;

#nullable disable

namespace CA_ImdbDb.Models
{
    public partial class Cast
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? MovieId { get; set; }

        public virtual Movie Movie { get; set; }
    }
}

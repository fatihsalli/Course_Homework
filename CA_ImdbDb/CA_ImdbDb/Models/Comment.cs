using System;
using System.Collections.Generic;

#nullable disable

namespace CA_ImdbDb.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
    }
}

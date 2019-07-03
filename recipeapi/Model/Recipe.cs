using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace recipeapi.Model
{
    [Table("recipe")]
    public partial class Recipe
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("main_ingredient")]
        [StringLength(255)]
        public string MainIngredient { get; set; }
        [Column("secondary_ingredient")]
        [StringLength(255)]
        public string SecondaryIngredient { get; set; }
        [Column("serves")]
        public int? Serves { get; set; }
        [Column("time_posted", TypeName = "date")]
        public DateTime? TimePosted { get; set; }
    }
}

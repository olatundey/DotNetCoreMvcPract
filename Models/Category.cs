using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BulkyDemo.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set;}
		[Required]
		[MaxLength(30,ErrorMessage = "The Category Name field is required")]
		[DisplayName("Category Name")]
		public string? Name { get; set;}
        [DisplayName("Display Order")]
		[Range(1,100,ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
        //      public Category()
        //{
        //}
        // suggests that the Name property in your Category class should be declared
		// as nullable. To resolve the warning, you can update the property
		// declaration to make it nullable by adding a ? after the property type. 
    }
}


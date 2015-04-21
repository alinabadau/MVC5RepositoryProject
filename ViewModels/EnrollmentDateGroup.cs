using System;
using System.ComponentModel.DataAnnotations;

namespace MVC5RepositoryProject.ViewModels
{
   public class EnrollmentDateGroup
   {
      [DataType(DataType.Date)]
      public DateTime? EnrollmentDate { get; set; }

      public int StudentCount { get; set; }
   }
}
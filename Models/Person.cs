using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Person
{
        public int? Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Class { get; set; }
        [Required]
        public int? Roll { get; set; }
         
        //  public static List<Person> Getstudents()
        //  {
        // Person std1= new Person (){Id=1,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // Person std2= new Person (){Id=2,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // Person std3= new Person (){Id=3,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // Person std4= new Person (){Id=4,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // Person std5= new Person (){Id=5,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // Person std6= new Person (){Id=6,FirstName="Rabi",LastName="Neupane",Class="10A",Roll=1 };
        // List<Person> students = new List<Person>() {std1,std2,std3,std4,std5,std6};
        // return students;
        //  }



}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    //create interface as generic constrain
    public interface IEntity
    {
        int Id { get; set; }
    }
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
    }

    public class User: IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    //example of generic class to use in order to show values from two classes in the same way but different types
    public class PaginatedResult<T>
    {
        public List<T> Results { get; set; }
        public int ResultsFrom { get; set; }
        public int ResultsTo { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
}

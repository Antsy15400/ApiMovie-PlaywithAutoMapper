using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Dtos
{
    public class GetMovieDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
    }
}
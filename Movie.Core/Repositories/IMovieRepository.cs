﻿
using MovieApp.Core.DTOs;
using MovieApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Core.Repositories
{
    public interface IMovieRepository:IGenericRepository<Movie>
    {
        public Task<List<MovieJoinDto>> GetAllMoviesWithGenre();
    }
}
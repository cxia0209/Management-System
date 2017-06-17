﻿using Infrastructure.Data.Data;
using Infrastructure.Data.GenericRepository;
using Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data.UOW
{
    public interface IUOW
    {
        void Commit();
        GenericRepository<user> UserRepository { get; }
        GenericRepository<movie> MovieRepository { get; }
        GenericRepository<director> DirectoryRepository { get; }
        GenericRepository<directorGenre> DirectorGenreRepository { get; }
        GenericRepository<directorMovie> DirectorMovieRepository { get; }
        GenericRepository<movieDirector> MovieDirectorRepository { get; }
        GenericRepository<movieGenre> MovieGenreRepository { get; }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tusa_Alexandra_Teodora_Lab2.Models;

namespace Tusa_Alexandra_Teodora_Lab2.Data
{
    public class Tusa_Alexandra_Teodora_Lab2Context : DbContext
    {
        public Tusa_Alexandra_Teodora_Lab2Context (DbContextOptions<Tusa_Alexandra_Teodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tusa_Alexandra_Teodora_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Tusa_Alexandra_Teodora_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Tusa_Alexandra_Teodora_Lab2.Models.Author> Author { get; set; } = default!;
    }
}

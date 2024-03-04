// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using EF;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

EshopContext context = new EshopContext(); 

context.Database.EnsureCreated();

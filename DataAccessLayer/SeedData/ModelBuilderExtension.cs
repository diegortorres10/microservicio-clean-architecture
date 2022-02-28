using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed Data for Admin Roles
            /*modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, State = true, Password = "1234", Person = new Person { PersonId = 1, Name = "Persona 1", Address = "Direccion 1", Age = 18, Gender = "Masculino", Identification = "1234567890", Phone = "02134578" } },
                new Client { ClientId = 2, State = true, Password = "1234", Person = new Person { PersonId = 1, Name = "Persona 2", Address = "Direccion 2", Age = 22, Gender = "Femenino", Identification = "78945632123", Phone = "02134578" } } 
            );*/
        }
    }
}

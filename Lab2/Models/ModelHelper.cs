

using AutoMapper;
using Lab2.Models.Domain;
using Lab2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class ModelHelper : Profile
    {
        public ModelHelper()
        {
            CreateMap<Product, ProductModels>();
            CreateMap<UserRegistrationModel, User>();
        }
    }
}


using API.Models;
using AutoMapper;
using DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        
        public AutoMapperProfile()
        {
            CreateMap<Solicitud, SolicitudResponse>().ReverseMap();
            CreateMap<SolicitudRequest, Solicitud>();
            CreateMap<SolicitudUpdate, Solicitud>();
        }
    }
}
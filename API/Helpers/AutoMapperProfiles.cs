using API.Entities;
using System;
using AutoMapper;
using API.DTOs;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using API.Extensions;

namespace API.Helpers
{

	public class AutoMapperProfiles : Profile
		{
	       public AutoMapperProfiles(){

			CreateMap<AppUser, MemberDto>()
				.ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(x => x.IsMain).Url)).ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));

			CreateMap<Photo, PhotoDto>();
		}
		}

}
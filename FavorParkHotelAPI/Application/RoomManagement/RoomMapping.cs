﻿using AutoMapper;
using FavorParkHotelAPI.Application.RoomManagement.Dto;
using FPH.Data.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FavorParkHotelAPI.Application.RoomManagement
{
    public class RoomMapping : Profile
    {
        public RoomMapping()
        {
            CreateMap<HotelRoomEntity, RoomDto>();
            CreateMap<ApplyRoomDto, HotelRoomEntity>()
                .ForMember(dest => dest.Id, opt => opt.Ignore()); // Ignore Id during mapping as it will be generated by the database
        }
    }
}

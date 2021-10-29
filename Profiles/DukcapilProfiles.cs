using AutoMapper;
using Wmfnnc.DTO;
using Wmfnnc.Models;

namespace Wmfnnc.Profiles
{
    public class DukcapilProfiles : Profile
    {
        public DukcapilProfiles()
        {
            //Source --> Target
            CreateMap<m_dukcapil_data, DukcapilRead>();
            CreateMap<DukcapilFind, DukcapilRead>();
            CreateMap<DukcapilCreate, m_dukcapil_data>();
        }
    }
}
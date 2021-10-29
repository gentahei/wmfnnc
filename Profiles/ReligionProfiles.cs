using AutoMapper;
using Wmfnnc.DTO;
using Wmfnnc.Models;

namespace Wmfnnc.Profiles
{
    public class ReligonProfiles : Profile
    {
        public ReligonProfiles()
        {
            //Source --> Target
            CreateMap<m_religion, ReligionRead>();
        }
    }
}
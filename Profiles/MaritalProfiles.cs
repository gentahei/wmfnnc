using AutoMapper;
using Wmfnnc.DTO;
using Wmfnnc.Models;

namespace Wmfnnc.Profiles
{
    public class MaritalProfiles : Profile
    {
        public MaritalProfiles()
        {
            //Source --> Target
            CreateMap<m_marital_status, MaritalRead>();
        }
    }
}
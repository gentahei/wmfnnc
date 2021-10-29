using System.Collections.Generic;
using Wmfnnc.Models;

namespace Wmfnnc.Data.Interface 
{
    public interface IDukcapilRepo
    {
        void CreateDukcapil(m_dukcapil_data dukcapil);
        void UpdateDukcapil(m_dukcapil_data dukcapil);
        List<m_dukcapil_data> GetAllDukcapil();
        m_dukcapil_data GetDukcapilByNik(string nik);
        void DeleteDukcapil(string nik);
    }
}
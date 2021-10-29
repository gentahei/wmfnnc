using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Wmfnnc.Data.Interface;
using Wmfnnc.Models;

namespace Wmfnnc.Data
{
    public class DukcapilRepo : IDukcapilRepo
    {
        private readonly AppDbContext _context;

        public DukcapilRepo(AppDbContext context)
        {
            _context = context;
        }

        public void CreateDukcapil(m_dukcapil_data dukcapil)
        {
            _context.m_dukcapil_data.Add(dukcapil);
            _context.SaveChanges();
        }

        public void DeleteDukcapil(string nik)
        {
            var dukcapil = _context.m_dukcapil_data.FirstOrDefault(q => q.nik == nik);

            if (dukcapil == null)
            {
                throw new ArgumentNullException(nameof(nik));

            }

            _context.Remove(dukcapil);
            _context.SaveChanges();
        }

        public List<m_dukcapil_data> GetAllDukcapil()
        {
            return _context.m_dukcapil_data
                    .Include(r => r.religion)
                    .Include(m => m.marital)
                    .ToList();
        }

        public m_dukcapil_data GetDukcapilByNik(string nik)
        {
            return _context.m_dukcapil_data
                    .Include(r => r.religion)
                    .Include(m => m.marital)
                    .FirstOrDefault(q => q.nik == nik);
        }

        public void UpdateDukcapil(m_dukcapil_data dukcapil)
        {
            var data = _context.m_dukcapil_data.FirstOrDefault(q => q.nik == dukcapil.nik);

            if (data == null)
            {
                throw new ArgumentNullException(nameof(dukcapil));
            }

            data.name = dukcapil.name;
            data.maiden_name = dukcapil.maiden_name;
            data.birth_date = dukcapil.birth_date;
            data.gender = dukcapil.gender;
            data.religion_id = dukcapil.religion_id;
            data.marital_status = dukcapil.marital_status;

            _context.SaveChanges();
        }
    }
}
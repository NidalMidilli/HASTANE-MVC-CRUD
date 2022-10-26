using BusinessLayer.Abstract;
using DataAccess.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HospitalMan : IHospitalService
    {
        IHospitalDAL hosdal;

        public HospitalMan(IHospitalDAL hosdal)
        {
            this.hosdal = hosdal;
        }

        public int AddHospital(Hastane p)
        {
            if(p.hastane_ad.Length > 10)
            {
                return -1;
            }
            return hosdal.Ekle(p);
        }

        public List<Hastane> GetAll()
        {
            return hosdal.Listt();
        }

        public int RemoveHospital(Hastane p)
        {          
                return hosdal.Sil(p);
                
        }

        public int UpdateHospital(Hastane p)
        {
         
                return hosdal.Guncelle(p);

        }
    }
}

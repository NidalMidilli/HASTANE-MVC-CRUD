using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHospitalService
    {

        public List<Hastane> GetAll();
        public int AddHospital(Hastane p);

        public int RemoveHospital(Hastane p);
        public int UpdateHospital(Hastane p);

        


    }
}

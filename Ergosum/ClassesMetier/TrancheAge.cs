using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ergosum.ClassesMetier
{
    class TrancheAge
    {
        private int code;
        private int ageMin;
        private int ageMax;

        public TrancheAge(int code, int ageMin, int ageMax)
        {
            this.Code = code;
            this.AgeMin = ageMin;
            this.AgeMax = ageMax;
        }

        public int Code { get => code; set => code = value; }
        public int AgeMin { get => ageMin; set => ageMin = value; }
        public int AgeMax { get => ageMax; set => ageMax = value; }
        
    }
}

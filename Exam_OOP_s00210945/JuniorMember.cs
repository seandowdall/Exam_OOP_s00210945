using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_OOP_s00210945
{
    class JuniorMember : Member
    {
        private string typeOfMember;

        public string TypeOfMember
        {
            get
            {
                return typeOfMember;
            }
            set
            {
                typeOfMember = "JuniorMember";
            }
        }
    }
}

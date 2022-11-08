using Core.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IStudent
    {
        bool AddStudent(VMStudent VMS);
        bool DeleteStudent(int Id);
        VMStudent UpdateStudent(int Id);
        bool EditStudent(VMStudent VMS);
        List<VMStudent> LVMS();

    }
}

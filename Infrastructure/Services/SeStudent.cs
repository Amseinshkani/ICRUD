using Core.Interface;
using Core.VM;
using Infrastructure.Data.DataConnection;
using Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class SeStudent : IStudent
    {
        private readonly DataContext _Context;

        public SeStudent(DataContext Data)
        {
            _Context = Data;
        }

        public TStudent GeteStudentById(int Id)
        {
            return _Context.DBstudents.SingleOrDefault(x => x.Id == Id);

        }

        public bool AddStudent(VMStudent VMS)
        {
            TStudent TS = new TStudent() 
            {
            FullName = VMS.FullName,
            Age=VMS.Age,
            Grade=VMS.Grade
            };
            _Context.DBstudents.Add(TS);
            _Context.SaveChanges();
            return true;
        }

        public bool DeleteStudent(int Id)
        {
            var select = _Context.DBstudents.Find(Id);
            _Context.DBstudents.Remove(select);
            _Context.SaveChanges();
            return true;
        }

        public VMStudent UpdateStudent(int Id)
        {
            var select = GeteStudentById(Id);
            VMStudent VMS = new VMStudent() 
            {
            Id=select.Id,
            FullName=select.FullName,
            Age=select.Age,
            Grade=select.Grade
            };
            return VMS;
        }
        
        public bool EditStudent(VMStudent VMS)
        {
            var Select = GeteStudentById(VMS.Id);

           Select.Id = VMS.Id;
           Select.FullName = VMS.FullName;
           Select.Age = VMS.Age;
           Select.Grade = VMS.Grade;
            
            _Context.DBstudents.Update(Select);
            _Context.SaveChanges();
            return true;
        }

        public List<VMStudent> LVMS()
        {
            List<VMStudent> LVM = new List<VMStudent>();

            foreach (var item in _Context.DBstudents)
            {
                VMStudent VM = new VMStudent();
                VM.Id = item.Id;
                VM.FullName = item.FullName;
                VM.Age = item.Age;
                VM.Grade = item.Grade;
                LVM.Add(VM);
            }
            return LVM;
        }

    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriverProject.Resourse
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int Id { get; set; }
        public int IdRole { get; set; }
        public Nullable<int> GUID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronomic { get; set; }
        public Nullable<decimal> Passport { get; set; }
        public string AdressReg { get; set; }
        public string AdressLive { get; set; }
        public string Company { get; set; }
        public string Place { get; set; }
        public Nullable<double> Phone { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Comment { get; set; }
    
        public virtual Role Role { get; set; }
    }
}

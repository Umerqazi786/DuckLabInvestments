//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DuckLab.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Games = new HashSet<Game>();
            this.GameUsers = new HashSet<GameUser>();
            this.UserStocks = new HashSet<UserStock>();
        }
    
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    
        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<GameUser> GameUsers { get; set; }
        public virtual ICollection<UserStock> UserStocks { get; set; }
    }
}
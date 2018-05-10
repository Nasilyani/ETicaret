using ETicaret.Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.Entity
{
   public class CoreEntity:IEntity
    {
        public CoreEntity()
        {
            this.Status = Status.Active;
            this.CreatedDate = DateTime.Now;
            this.CreatedUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIp = (Dns.GetHostEntry(Dns.GetHostName())).ToString();
            //created by'ı birinin hesabını oluştururken değilde urun yada kategorı eklemelerınde kullan genericlere yazmayı unutma!!

        }

        [Key]
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }
        public string CreatedUserName { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIp { get; set; }
        public string ModifiedUserName { get; set; }
        public Guid? ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18_Delegates_Events.Models
{
    public class Machine
    {
        public string Id { get; }
        public event Action<string, string> StatusChanged;
        public Machine(string id) 
        {
            Id = id;
        }

        public void  Start()
        {
            OnStatusChanged("Running");
        }
        public void Stop()
        {
            OnStatusChanged("Stopped");
        }

        protected virtual void OnStatusChanged(string status)
        {
            StatusChanged?.Invoke(Id, status);
        }

    }
}

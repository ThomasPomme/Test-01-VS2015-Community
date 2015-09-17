using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjj.Core.Models
{
    public abstract class Box
    {
        public Box (string title, string text)
        {

        }

        private string title { get; set; }
        private string text { get; set; }

        public abstract void Open();
    }
}

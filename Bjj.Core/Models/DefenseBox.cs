using Bjj.Core.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjj.Core.Models
{
    public class DefenseBox : Box, IDefenseBox
    {
        public DefenseBox(string title, string text) : base(title, text)
        {
        }
        public override void Open()
        {
            throw new NotImplementedException();
        }
    }
}

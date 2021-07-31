using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoodi.Controls
{
    public class PlofilePageFlyoutMenuItem
    {
        public PlofilePageFlyoutMenuItem()
        {
            TargetType = typeof(PlofilePageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
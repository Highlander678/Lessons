using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public partial class sql_base_1 : Component
    {
        public sql_base_1()
        {
            InitializeComponent();
        }

        public sql_base_1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

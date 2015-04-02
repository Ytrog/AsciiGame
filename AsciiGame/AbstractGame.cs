using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiGame
{
    public abstract partial class AbstractGame : Component
    {
        public AbstractGame()
        {
            InitializeComponent();
        }

        public AbstractGame(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}

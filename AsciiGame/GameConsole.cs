using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsciiGame
{
    class GameConsole : Component
    {
        private bool _running;
        public void Start()
        {
            _running = true;
            while (_running)
            {
                HandleInput();   
                
            }
        }

        protected virtual void HandleInput()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse_Defense
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        // Returns: true if the player wins, false otherwise.
        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {

                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                // Count and move the invaders that are still active.
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }

            return true;

        }
    }
}

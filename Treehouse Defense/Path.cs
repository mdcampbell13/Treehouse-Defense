using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse_Defense
{
    class Path
    {

        private MapLocation[] _path;

        public int Length => _path.Length;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }
    }
}

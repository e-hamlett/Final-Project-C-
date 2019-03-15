﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WAGFactory;

namespace Iterator
{
    public class GadgetRange
    {
        private IWag[] _wags;

        public virtual IWag[] Range
        {
            get { return _wags; }
        }

        public GadgetRange()
        {
            _wags = new IWag[3];

            _wags[0] = new SmallGadget();
            _wags[1] = new MediumGadget();
            _wags[2] = new LargeGadget();




        }

        public virtual IEnumerator<IWag> GetEnumerator()
        {
            return ((IEnumerable<IWag>)_wags).GetEnumerator();
        }
    }
}
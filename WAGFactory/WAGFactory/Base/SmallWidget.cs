﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAGFactory
{
    public class SmallWidget : AbstractWidget
    {
        public SmallWidget()
        {
        }

        public SmallWidget(ISize size) : base(size)
        {
        }

        public SmallWidget(ISize size, FinishColor color) : base(size, color)
        {
        }

        public override ISize Size => throw new NotImplementedException();

        public override decimal Price => base.Price;

        public override void Paint(FinishColor color)
        {
            base.Paint(color);
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}

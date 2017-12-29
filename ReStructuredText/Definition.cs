﻿using System.Collections.Generic;

namespace Lextm.ReStructuredText
{
    public class Definition
    {
        public Definition(Paragraph paragraph)
        {
            Elements = new List<IElement> {paragraph};
        }

        public IList<IElement> Elements { get; }

        public void Add(IElement element)
        {
            Elements.Add(element);
        }
    }
}
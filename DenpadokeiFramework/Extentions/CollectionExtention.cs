﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DenpadokeiFramework.Extentions
{
    public static class CollectionExtention
    {
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> list)
        {
            if (list == null) {
                throw new ArgumentNullException();
            }

            foreach (var item in list) {
                collection.Add(item);
            }
        }
    }
}

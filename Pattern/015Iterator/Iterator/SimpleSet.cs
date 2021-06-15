﻿using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Iterator
{
    class SimpleSet<T> : IEnumerable<T>
    {
        readonly T[] storage;
        public SimpleSet(IEnumerable<T> args) => storage = args.ToArray();

        public IEnumerator<T> GetEnumerator()
        {
            var len = storage.Length;
            for (int i = 0; i < len; i++)
                yield return storage[i];
        }
 
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}

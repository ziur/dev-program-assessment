using System.Collections.Generic;

namespace Assessment
{
    public interface IElementsProvider<T>
    {
        public IEnumerable<T> ProcessData(T source);
    }
}
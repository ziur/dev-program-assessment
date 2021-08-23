using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class PaginationString : IPagination<string>
    {
        private readonly IEnumerable<string> data;
        private readonly int pageSize;
        private int currentPage;

        public PaginationString(string source, int pageSize, IElementsProvider<string> provider)
        {
            data = provider.ProcessData(source);
            currentPage = 1;
            this.pageSize = pageSize;
        }
        public void FirstPage()
        {
            currentPage = 1;
        }

        public void GoToPage(int page)
        {
            throw new System.NotImplementedException();
        }

        public void LastPage()
        {
            throw new System.NotImplementedException();
        }

        public void NextPage()
        {
            
        }

        public void PrevPage()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<string> GetVisibleItems()
        {
            return data.Skip(currentPage*pageSize).Take(5);
        }

        public int CurrentPage()
        {
            throw new System.NotImplementedException();
        }

        public int Pages()
        {
            throw new System.NotImplementedException();
        }
    }
}
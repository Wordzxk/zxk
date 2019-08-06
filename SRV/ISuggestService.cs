using System.Collections.Generic;
using BLL;

namespace SRV
{
    public interface ISuggestService
    {

        Suggest Publish(Blog dblog);
        Suggest Get(int id);
        IList<Blog> Get(int pageIndex, int pageSize);
    }
}
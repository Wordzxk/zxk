using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Suggest
{
   internal class NewFactory
    {
        private static SuggsetService _suggsetService;
        static NewFactory()
        {
            _suggsetService = new SuggsetService();
        }

        internal static void Create()
        {
            _suggsetService.Publish("测试B发布的问题", "这是bady", RegisterFactory.CeshiB.Id);
        }
    }
}

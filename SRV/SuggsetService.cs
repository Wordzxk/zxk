using BLL;
using BLL.Repositorys;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggsetService
    {
        private SuggestRepository _suggestRepository;
        public SuggsetService()
        {
            _suggestRepository = new SuggestRepository();
        }

        public Suggest Publish(string title, string body, int authorId)
        {
            UserRepository userRepository = new UserRepository();
            //userRepository.CurrentContext = _suggestRepository.CurrentContext;

            Suggest suggest = new Suggest
            {
                Author = new UserRepository().GetById(authorId),
                Body = body,
                Title = title,

            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);


        }
    }
}

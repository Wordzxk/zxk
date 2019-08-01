using BLL;
using BLL.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggestService 
    {
        private SuggestRepository _suggestRepository;
        public SuggestService()
        {
            _suggestRepository = new SuggestRepository();
        }

        public Suggest Publish(string title, string body, int authorId)
        {
            UserRepository userRepository = new UserRepository();
            userRepository.CurrentContext = _suggestRepository.CurrentContext;
            userRepository.SetEntities(_suggestRepository.CurrentContext);

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

using BLL;
using BLL.Repositorys;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRV
{
    public class SuggestService : BaseService, ISuggestService
    {
        private SuggestRepository _suggestRepository;
        public SuggestService(
            IHttpContextAccessor accessor,
            SuggestRepository suggestRepository,
            UserRepository userRepository) : base(accessor, userRepository)
        {
            _suggestRepository = suggestRepository;
        }
        //暂未引用
        public DTOSuggest Get(int id)
        {
            Suggest suggest = _suggestRepository.Get(id);

            return new DTOSuggest
            {
                Title = suggest.Title,
                Body = suggest.Body
            };
        }

        public Suggest Publish(string title, string body/*, int authorId*/)
        {
            UserRepository userRepository = new UserRepository();
            //userRepository.CurrentContext = _suggestRepository.CurrentContext;
            //userRepository.SetEntities(_suggestRepository.CurrentContext);

            Suggest suggest = new Suggest
            {
                Author = currentUser,
                Body = body,
                Title = title,

            };
            suggest.Publish();
            return _suggestRepository.Save(suggest);
        }

    }
    public class DTOSuggest
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}

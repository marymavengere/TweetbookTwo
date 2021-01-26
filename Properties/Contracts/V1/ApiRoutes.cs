using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TweetbookTwo.Properties.Contracts
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public static readonly string Base = $"{Root}/{Version}";

        public static class Posts
            {
             public static readonly string GetAll = $"{Base}/posts";
             //public const string Create = "api/v1/posts";
           //  public const string Get = "api/v1/posts{postId}";
        }
    }
}

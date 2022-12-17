using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab007
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum)]
    public class CommentAttribute : Attribute
    {
        private readonly string comment;
        public CommentAttribute(string _comment)
        {
            comment = _comment;
        }
        public string Comment
        {
            get { return comment; }
        }
    }
}
using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace MyDevPortfolioAPI.Application.Common.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        private readonly string _name;
        private readonly object _key;
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
            _key = key;
            _name = name;
        }
        public string Name { get { return _name; } }
        public object Key { get { return _key; } }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            _name = info.GetString("MyException.Name");
            _key = info.GetValue("MyException.Key", typeof(object));
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("MyException.Name", _name);
            info.AddValue("MyException.Key", _key, typeof(object));
        }
    }
}

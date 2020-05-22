using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using FluentValidation.Results;

namespace MyDevPortfolioAPI.Application.Common.Exceptions
{
    [Serializable]
    public class ValidationException : Exception
    {
        private readonly IDictionary<string, string[]> _failures;
        public ValidationException()
            : base("One or more validation failures have occurred.")
        {
            _failures = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
            : this()
        {
            var failureGroups = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage);

            foreach (var failureGroup in failureGroups)
            {
                var propertyName = failureGroup.Key;
                var propertyFailures = failureGroup.ToArray();

                Failures.Add(propertyName, propertyFailures);
            }
        }

        public IDictionary<string, string[]> Failures { get { return _failures; } }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        protected ValidationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            _failures = (IDictionary<string,string[]>)info
                                .GetValue("ValidationException.Failures", typeof(IDictionary<string,string[]>));
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            info.AddValue("ValidationException.Failures", this.Failures, typeof(IDictionary<string, string[]>));
        }
    }
}
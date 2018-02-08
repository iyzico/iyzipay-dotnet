using System;
using System.Collections.Generic;

namespace Iyzipay
{
    public class ToStringRequestBuilder
    {
        private List<string> parameters = new List<string>();

        private ToStringRequestBuilder(String requestString)
        {
            if (!string.IsNullOrWhiteSpace(requestString))
            {
                parameters.Add(requestString);
            }
        }

        public static ToStringRequestBuilder NewInstance()
        {
            return new ToStringRequestBuilder("");
        }

        public static ToStringRequestBuilder NewInstance(String requestString)
        {
            return new ToStringRequestBuilder(requestString);
        }

        public ToStringRequestBuilder AppendSuper(String superRequestString)
        {
            if (superRequestString != null)
            {
                superRequestString = superRequestString.Substring(1);
                superRequestString = superRequestString.Substring(0, superRequestString.Length - 1);

                if (superRequestString.Length > 0)
                {
                    parameters.Add(superRequestString);
                }
            }
            return this;
        }

        public ToStringRequestBuilder Append(String key, Object value = null)
        {
            if (value != null)
            {
                if (value is RequestStringConvertible)
                {
                    parameters.Add($"{key}={((RequestStringConvertible)value).ToPKIRequestString()}");

                }
                else
                {
                    parameters.Add($"{key}={value}");
                }
            }
            return this;
        }

        public ToStringRequestBuilder AppendPrice(String key, String value)
        {
            if (value != null)
            {
                parameters.Add($"{key}={RequestFormatter.FormatPrice(value)}");
            }
            return this;
        }

        public ToStringRequestBuilder AppendList<T>(String key, List<T> list = null) where T : RequestStringConvertible
        {
            if (list != null)
            {
                List<string> valueList = new List<string>();
                foreach (RequestStringConvertible val in list)
                {
                    valueList.Add(val.ToPKIRequestString());
                }
                parameters.Add($"{key}=[{string.Join(", ", valueList)}]");
            }
            return this;
        }

        public ToStringRequestBuilder AppendList(String key, List<int> list = null)
        {
            if (list != null)
            {
                parameters.Add($"{key}=[{string.Join(", ", list)}]");
            }
            return this;
        }


        public String GetRequestString()
        {
            return $"[{string.Join(",", parameters)}]";
        }
    }
}


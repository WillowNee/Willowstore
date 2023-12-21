﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Willownet.BL.General;

namespace Willowtest.Helpers
{
    public class TestCookie : IWebCookie
    {
        Dictionary<string, string> cookies = new Dictionary<string, string>();

        public void Add(string cookieName, string value, int days = 0)
        {
            cookies.Add(cookieName, value);
        }

        public void AddSecure(string cookieName, string value, int days = 0)
        {
            cookies.Add(cookieName, value);
        }

        public void Delete(string cookieName)
        {
            cookies.Remove(cookieName);
        }

        public string? Get(string cookieName)
        {
            if (cookies.ContainsKey(cookieName))
                return cookies[cookieName];
            return null;
        }

        public void Clear()
        {
            cookies.Clear();
        }
    }
}
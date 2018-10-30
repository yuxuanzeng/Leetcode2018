using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class _93RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            var ret = new List<string>();
            backtrack(ret, s, "", 0,0);
            return ret;
        }

        private void backtrack(IList<string> ret, string s, string ip, int start, int part)
        {
            if (part == 4)
            {
                if (start == s.Length)
                {
                    ret.Add(ip);
                }
                else
                {
                    return;
                }
            }

            for (var i = 0; i <= 2 && i + start < s.Length; i++)
            {
                if ( i == 0
                     || (i >=1 && s[start] != '0' && int.Parse(s.Substring(start, i + 1)) <= 255))
                {
                    var subIpLen = i + 1;
                    if (!string.IsNullOrEmpty(ip))
                    {
                        subIpLen++;
                        ip += "." + s.Substring(start, i + 1);
                    }
                    else
                    {
                        ip = s.Substring(start, i + 1);
                    }
                    backtrack(ret, s, ip, start + i + 1, part + 1);
                    ip = ip.Remove(ip.Length - subIpLen, subIpLen);
                }
            }
        }
    }
}

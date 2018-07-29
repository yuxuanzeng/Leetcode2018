using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    public class _591TagValidator
    {
        public bool IsValid(string code)
        {
            //var code = "<DIV></DIV>";
            //var code = "<DIV>This is the first line <![CDATA[<div>]]></DIV>";
            //var code ="<DIV>>>  ![cdata[]] <![CDATA[<div>]>]]>]]>>]</DIV>";
            //var code ="<A>  <B> </A>   </B>";
            //var code ="<DIV>  div tag is not closed  <DIV>";
            //var code ="<DIV>  unmatched <  </DIV>";
            //var code ="<DIV> closed tags with invalid tag name <b>123</b> </DIV>";
            //var code ="<DIV> unmatched tags with invalid tag name  </1234567890> and <CDATA[[]]>  </DIV>";
            //var code ="<DIV>  unmatched start tag <B>  and unmatched end tag </C>  </DIV>";
            //var code ="<A><A>456</A>  <A> 123  !!  <![CDATA[]]>  123 </A>   <A>123</A></A>";
            //var code = "<A><A>456</A></A>";
            if (string.IsNullOrEmpty(code))
            {
                return false;
            }
            if (code.Length < 7)
            {
                return false;
            }
            if (code[0] != '<' || code[code.Length - 1] != '>')
            {
                return false;
            }
            var beginTag = string.Empty;
            var i = 1;
            while (code[i] != '>' && i < code.Length)
            {
                beginTag += code[i].ToString();
                i++;
            }
            if (beginTag.Length > (code.Length - 5) / 2)
            {
                return false;
            }

            if (!IsValidTag(beginTag))
            {
                return false;
            }
            if (code.Substring(code.Length - beginTag.Length - 3, beginTag.Length + 2) != "</" + beginTag)
            {
                return false;
            }
            return IsValidContent(code.Substring(beginTag.Length + 2, code.Length - beginTag.Length * 2 - 5));
        }

        public bool IsValidTag(string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                return false;
            }
            if (tag.Length > 9)
            {
                return false;
            }
            return !tag.Any(letter => letter < 65 || letter > 90);
        }

        public bool IsValidContent(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                return true;
            }
            var tags = new Stack<string>();
            var index = 0;
            //var tag = string.Empty;
            while (index <= content.Length - 2)
            {
                if (content[index] != '<')
                {
                    index++;
                    continue;
                }
                else
                {
                    if (content[index + 1] == '/')
                    {
                        var tagEnd = content.IndexOf('>', index);
                        if (tagEnd == -1)
                        {
                            return false;
                        }
                        var tag = content.Substring(index + 2, tagEnd - index - 2);
                        if (!IsValidTag(tag))
                        {
                            return false;
                        }
                        if (tags.Count() == 0 || tags.Pop() != tag)
                        {
                            //return true;
                            return false;
                        }
                        index = tagEnd + 1;
                        continue;
                    }
                    else if (content[index + 1] != '!')
                    {
                        if (content.Length < index + 7)
                        {
                            return false;
                        }
                        var tagEnd = content.IndexOf('>', index);
                        if (tagEnd == -1)
                        {
                            return false;
                        }
                        var tag = content.Substring(index + 1, tagEnd - index - 1);
                        if (!IsValidTag(tag))
                        {
                            //return true;
                            return false;
                        }
                        tags.Push(tag);
                        index = tagEnd + 1;
                        continue;
                    }
                    else
                    {
                        if (content.Length < index + 12)
                        {
                            return false;
                        }
                        if (content.Substring(index, 9) != "<![CDATA[")
                        {
                            return false;
                        }
                        var cDataEnd = content.IndexOf("]]>", index + 9);
                        if (cDataEnd == -1)
                        {
                            return false;
                        }
                        index = cDataEnd + 1;
                        continue;
                    }
                }
            }
            return content[content.Length - 1] != '<' && tags.Count() == 0;
            /*var begin = 0;
            var end = content.Length - 1;
            while(content[begin] != '<' && begin < content.Length - 1){
                begin ++;
            }
            while(content[end] != '>' && end > begin){
                if (content[end] == '<'){
                    return false;
                }
                end --;
            }
            if (end == begin){
                if (content[begin] != '<'){
                    return true;
                }
                return false;
            }
            if (end - begin <6){
                return false;
            }
            if (content[begin + 1] != '!'){
                return IsValidd(content.Substring(begin, end - begin + 1));
            }
            else{
                return IsValidCData(content.Substring(begin, end - begin + 1));
            }*/
        }

        public bool IsValidCData(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                return false;
            }
            if (data.Length < 12)
            {
                return false;
            }
            if (data.Substring(0, 9) != "<![CDATA[")
            {
                return false;
            }
            var startIndex = data.IndexOf("]]>", 9);
            if (startIndex == -1)
            {
                return false;
            }
            return IsValidContent(data.Substring(startIndex + 1, data.Length - startIndex - 1));
        }
    }
}

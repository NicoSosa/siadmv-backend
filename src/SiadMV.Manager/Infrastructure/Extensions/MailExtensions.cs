using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SiadMV.Manager.Infrastructure.Extensions
{
    public static class MailExtensions
    {
        private static bool _isValid = true;
        
        public static bool IsValidEmail(this string source)
        {
            if (string.IsNullOrEmpty(source))
                return false;
            
            try
            {
                if (_isValid)
                {
                    source = Regex.Replace(
                        source,
                        @"(@)(.+)$",
                        DomainMapper,
                        RegexOptions.None,
                        TimeSpan.FromMilliseconds(200));
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            
            if (!_isValid)
                return false;
            
            try
            {
                return Regex.IsMatch(source,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase,
                      TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        
        private static string DomainMapper(Match match)
        {
            var idnMapping = new IdnMapping();
            var domainName = match.Groups[2].Value;
            
			try
            {
                domainName = idnMapping.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                _isValid = false;
            }
            
			return match.Groups[1].Value + domainName;
        }
    }
}

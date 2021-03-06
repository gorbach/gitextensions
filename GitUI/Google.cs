﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using GitCommands;

namespace GitUI
{
    public static class Google
    {
        /// <summary>
        /// Translate Text using Google Translate API's
        /// Google URL - http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}
        /// </summary>
        /// <param name="input">Input string</param>
        /// <param name="languagePair">2 letter Language Pair, delimited by "|".
        /// E.g. "ar|en" language pair means to translate from Arabic to English</param>
        /// <returns>Translated to String</returns>
        public static string TranslateText(
            string input,
            string translateFrom,
            string translateTo)
        {
            string url = "http://ajax.googleapis.com/ajax/services/language/translate";
            WebClient webClient = new WebClient();
            webClient.Proxy = WebRequest.DefaultWebProxy;
            webClient.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            webClient.Encoding = System.Text.Encoding.UTF8;
            webClient.QueryString.Add("v", "1.0");
            webClient.QueryString.Add("q", HttpUtility.UrlEncode(input));
            webClient.QueryString.Add("langpair", string.Format("{0}|{1}", translateFrom, translateTo));
            webClient.QueryString.Add("key", "ABQIAAAAL-jmAvZrZhQkLeK6o_JtUhSHPdD4FWU0q3SlSmtsnuxmaaTWWhRV86w05sbgIY6R6F3MqsVyCi0-Kg");
            string result = webClient.DownloadString(url);

            string startString = "{\"translatedText\":\"";
            string detectedSourceLanguageString = "\",\"detectedSourceLanguage\":";
            string endString = "\"}";

            int startOffset = result.IndexOf(startString) + startString.Length;
            int length = result.IndexOf(detectedSourceLanguageString, startOffset) - startOffset;
            if (length < 0)
                length = result.IndexOf(endString, startOffset) - startOffset;

            if (length <= 0)
                return input;

            result = result.Substring(startOffset, length);
            return result;
        }
    }
}

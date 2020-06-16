using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Weather
{
    class YandexTranslator
    {
        public class Translation
        {
            public List<string> Text { get; set; }
            public string Lang { get; set; }
            public int Code { get; set; }
        }

        private static readonly HttpClient client = new HttpClient();

        public static string Translate(string TextForTranslate)
        {
            using (var wb = new WebClient())
            {
                var reqData = new NameValueCollection();
                reqData["text"] = TextForTranslate;
                reqData["lang"] = "ru"; //язык, на который перевод нужен
                reqData["key"] = "trnsl.1.1.20200420T112530Z.aaa939a816794b8a.05853d67f8c1caf4c5d646cb361f838211eb9ab2";
                try
                {
                    var response = wb.UploadValues("https://translate.yandex.net/api/v1.5/tr.json/translate", "POST", reqData);
                    string responseInString = Encoding.UTF8.GetString(response);
                    var rootObject = JsonConvert.DeserializeObject<Translation>(responseInString);
                    string TranslateText = rootObject.Text[0];
                    return TranslateText.Substring(0, 1).ToUpper() + (TranslateText.Length > 1 ? TranslateText.Substring(1) : "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка перевода: " + ex.Message, "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    throw;
                }
            }
        }
    }
}
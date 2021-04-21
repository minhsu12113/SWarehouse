using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static SWarehouse.Enums.ALL_ENUM;

namespace SWarehouse.Internationalization
{
    public class StringResources
    {
        private static string ClassName = "StringResources";
        private static ResourceDictionary Dict = new ResourceDictionary();
        public static int curLanguage = -1;
        public static string Find(string key)
        {
            return Dict.Contains(key) ? Dict[key].ToString() : "";
        }

        public static string Find(string key, params object[] list)
        {
            if (list.Length > 0)
                return Dict.Contains(key) ? string.Format(Dict[key].ToString(), list) : "";
            return Dict.Contains(key) ? Dict[key].ToString() : "";
        }

        public static void ApplyLanguage(Language language)
        {
            if (Dict == null)
                Dict = new ResourceDictionary();
            if (curLanguage == (int)language)
                return;

            curLanguage = (int)language;

            if (Application.Current.Resources.MergedDictionaries.Contains(Dict))
                Application.Current.Resources.MergedDictionaries.Remove(Dict);
            switch (language)
            {
                case Language.EN:
                    Dict.Source = new Uri("Internationalization\\StringResource_EN.xaml", UriKind.Relative);
                    break;
                case Language.VN:
                    Dict.Source = new Uri("Internationalization\\StringResource_VI.xaml", UriKind.Relative);//Vietnamese
                    break;
                default:
                    break;
            }
            Application.Current.Resources.MergedDictionaries.Add(Dict);
        }
    }
}
